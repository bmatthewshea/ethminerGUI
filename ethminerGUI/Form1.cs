using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ethminerGUI
{
    public partial class Form1 : Form
    {
        // form class
        string Filepath = Application.StartupPath + "\\profiles.xml";
        string console_tee = Application.StartupPath + "\\wtee.exe";
        //cmd
        //string LogString = String.Format(" >> \"\"{0}\\{1}\"\"", Application.StartupPath, "output.log");
        string LogString = String.Format(" 2>&1 | wtee.exe {0}", "output.log");
        //powershell
        //string LogString = " 2>&1 | tee " + "\'" + Application.StartupPath + "\\output.log\'";
        string ethminerpath = Application.StartupPath;
        string ethminerexe = "ethminer.exe";
        string ethminercommand = "ethminer.exe ";
        string ethminercommand_alt = "";

        public Form1()
        {
            InitializeComponent();
            CreateXMLFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDefaults();
            LoadProfiles();
            LoadApplicationDefaultsEthminerGUI();
            SetCommand();
            // Keep tooltip for built command ON for as long as possible..
            ToolTipEGUI.AutoPopDelay = 32766;
            ToolTipEGUI.ReshowDelay = 0;
            this.ActiveControl = labelProfiles;
        }

        private void ClearLeft()  // also part of the form defaults
        {
            RadioStratumMode.Enabled = false;
            RadioFarmMode.Enabled = false;
            TextBoxPool1.Text = "";
            TextBoxPool1.Enabled = false;
            TextBoxPoolPort1.Text = "";
            TextBoxPoolPort1.Enabled = false;
            TextBoxPool2.Text = "";
            TextBoxPool2.Enabled = false;
            TextBoxPoolPort2.Text = "";
            TextBoxPoolPort2.Enabled = false;
            TextBoxRecheck.Enabled = false;
            TextBoxAccount.Text = "";
            TextBoxAccount.Enabled = false;
            TextBoxWorker.MaxLength = 16;
            TextBoxWorker.Text = "";
            TextBoxWorker.Enabled = false;
            TextBoxEmail.Text = "";
            TextBoxEmail.Enabled = false;
            RadioButtonOpenCL.Enabled = false;
            RadioButtonCUDA.Enabled = false;
            RadioButtonMixedCards.Enabled = false;
            CheckBoxRH.Checked = false;
            CheckBoxRH.Enabled = false;
            CheckBoxHWMON.Checked = false;
            CheckBoxHWMON.Enabled = false;
            RadioButtonSC1.Enabled = false;
            RadioButtonSC2.Enabled = false;
            RadioButtonSP0.Enabled = false;
            RadioButtonSP1.Enabled = false;
            RadioButtonSP2.Enabled = false;
            LabelProfileNameLoaded.Text = "(none)";
        }

        private void EnableGPUEditOnly() // after disbale all, can enable just gpu area for benchmark and sim
        {
            RadioButtonOpenCL.Enabled = true;
            RadioButtonCUDA.Enabled = true;
        }

        private void EnableLeftEdit()  // unlocks left side of form for data entry
        {
            RadioStratumMode.Enabled = true;
            RadioFarmMode.Enabled = true;
            TextBoxPool1.Enabled = true;
            TextBoxPoolPort1.Enabled = true;
            TextBoxPool2.Enabled = true;
            TextBoxPoolPort2.Enabled = true;
            TextBoxRecheck.Enabled = true;
            TextBoxAccount.Enabled = true;
            TextBoxWorker.Enabled = true;
            TextBoxEmail.Enabled = true;
            RadioButtonOpenCL.Enabled = true;
            RadioButtonCUDA.Enabled = true;
            RadioButtonMixedCards.Enabled = true;
            CheckBoxRH.Checked = true;
            CheckBoxRH.Enabled = true;
            CheckBoxHWMON.Checked = true;
            CheckBoxHWMON.Enabled = true;
            RadioButtonSC1.Enabled = true;
            RadioButtonSC2.Enabled = true;
            RadioButtonSP0.Enabled = true;
            RadioButtonSP1.Enabled = true;
            RadioButtonSP2.Enabled = true;
        }
        private void ClearRight() // also part of the form defaults
        {
            EnableBenchmark.Checked = false;
            benchmarkseconds.Text = "";
            benchmarkseconds.Enabled = false;
            benchmarktrialsecs.Text = "";
            benchmarktrialsecs.Enabled = false;
            benchmarktrials.Text = "5";
            benchmarktrials.Enabled = false;
            EnableSimulation.Checked = false;
            TextBoxSimblock.Text = "";
            TextBoxSimblock.Enabled = false;
            TextBoxProfileSaveName.Text = "";
            GroupBoxProfileSave.Visible = false;
            //enableWatchdog.Checked = false;  //Watchdog in future release
            //watchdogtimeout.Text = "";
            SetupButtons();
        }

        private void DisableGroupsForBenchmark()
        {
            Worktype.Enabled = false;
            GroupBoxPools.Enabled = false;
            //groupBoxGPU.Enabled = false;
            GroupBoxClientType.Enabled = false;
            GroupBoxStratumProtocol.Enabled = false;
            GroupBoxSimulation.Enabled = false;
            GroupBoxWatchDog.Enabled = false;
            ListBoxProfiles.Enabled = false;
            GroupBoxProfileSave.Visible = false;
            LabelProfileNameLoaded.Text = "(none)";
        }
        private void DisableGroupsForSimulation()
        {
            Worktype.Enabled = false;
            GroupBoxPools.Enabled = false;
            //groupBoxGPU.Enabled = false;
            GroupBoxClientType.Enabled = false;
            GroupBoxStratumProtocol.Enabled = false;
            GroupBoxBenchmark.Enabled = false;
            GroupBoxWatchDog.Enabled = false;
            ListBoxProfiles.Enabled = false;
            GroupBoxProfileSave.Visible = false;
            LabelProfileNameLoaded.Text = "(none)";
        }
        private void EnableGroups()
        {
            Worktype.Enabled = true;
            GroupBoxPools.Enabled = true;
            groupBoxGPU.Enabled = true;
            GroupBoxClientType.Enabled = true;
            GroupBoxStratumProtocol.Enabled = true;
            GroupBoxBenchmark.Enabled = true;
            GroupBoxSimulation.Enabled = true;
            GroupBoxWatchDog.Enabled = true;
            ListBoxProfiles.Enabled = true;
            GroupBoxProfileSave.Visible = true;
        }
        private void SetupButtons()
        {
            DisableButtons();

            //Mining Start Button
            if (TextBoxPool1.Text != "" || EnableBenchmark.Checked || EnableSimulation.Checked)
            {
                ButtonStartMining.Text = "Start Miner";
                ButtonStartMining.ForeColor = Color.Green;
                ButtonStartMining.Enabled = true;
            }

            //load, save/edit ,delete buttons
            if ((ListBoxProfiles.Items.Count != 0) && (ListBoxProfiles.SelectedItem != null))
            {
                ButtonLoadProfile.Enabled = true;
                ButtonRemoveProfile.Enabled = true;
            }
            ButtonAddProfile.Enabled = true;
            //if (LabelProfileNameLoaded.Text == "(none)")

        }
        private void DisableButtons()
        {
            ButtonStartMining.Enabled = false;
            ButtonLoadProfile.Enabled = false;
            ButtonAddProfile.Enabled = false;
            ButtonRemoveProfile.Enabled = false;
        }
        private void LoadDefaults()
        {
            ClearLeft();
            ClearRight();
        }
        private void BenchmarkMode()
        {
            EnableSimulation.Checked = false;
            TextBoxSimblock.Enabled = false;
            SetupButtons();
            SetCommand();
        }
        private void SimulationMode()
        {
            EnableBenchmark.Checked = false;
            benchmarkseconds.Enabled = false;
            benchmarktrialsecs.Enabled = false;
            benchmarktrials.Enabled = false;
            SetupButtons();
            SetCommand();
        }

        private void EnableBenchmark_Click(object sender, EventArgs e)
        {
            if (EnableBenchmark.Checked)
            {
                ClearLeft();
                EnableGPUEditOnly();
                DisableGroupsForBenchmark();
                BenchmarkMode();
            }
            else
            {
                EnableGroups();
                ClearLeft();
                ClearRight();
                SetupButtons();
                SetCommand();
            }
        }

        private void EnableSimulation_Click(object sender, EventArgs e)
        {
            if (EnableSimulation.Checked)
            {
                ClearLeft();
                EnableGPUEditOnly();
                DisableGroupsForSimulation();
                SimulationMode();
            }
            else
            {
                EnableGroups();
                ClearLeft();
                ClearRight();
                SetupButtons();
                SetCommand();
            }
        }

        private void EnableBenchmark_CheckStateChanged(object sender, EventArgs e)
        {
            benchmarkseconds.Enabled = (EnableBenchmark.CheckState == CheckState.Checked);
            benchmarktrialsecs.Enabled = (EnableBenchmark.CheckState == CheckState.Checked);
            benchmarktrials.Enabled = (EnableBenchmark.CheckState == CheckState.Checked);
        }

        private void EnableSimulation_CheckStateChanged(object sender, EventArgs e)
        {
            TextBoxSimblock.Enabled = (EnableSimulation.CheckState == CheckState.Checked);
        }

        private void CheckBoxCreateLog_CheckStateChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void ButtonAddProfile_Click(object sender, EventArgs e)
        {
            ClearLeft();
            ClearRight();
            EnableLeftEdit();
            EnableGroups();
            ButtonAddProfile.Enabled = false;
            this.ActiveControl = TextBoxPool1;
        }

        private void LoadProfiles()
        {
            var loadprofiles = Utilities.DeSerializeObject<Profiles>(Filepath);

            //clear out first then load
            ListBoxProfiles.Items.Clear();

            foreach (var item in loadprofiles.ProfileList)
            {
                ListBoxProfiles.Items.Add(item.Name);
            }

            if (ListBoxProfiles.Items.Count != 0)
            {
                ButtonLoadProfile.Enabled = true;
            }
        }

        private void buttonLoadProfile_Click(object sender, EventArgs e)
        {
            PopulateProfile();  // First LoadProfiles() into listbox then populate under this method for selected item for loading single one
        }

        private string SetCommand()
        {
            // method variables:
            var gpu = "";
            var sc = 1;
            var sp = 0;
            var worktype = "";
            //Clear the current command / start over each time
            ethminercommand = "";
            // grab current radio values first
            SetRadioValues(out worktype, out gpu, out sc, out sp);

            // Check for benchmark or simulation first - skip rest if true
            if (EnableBenchmark.Checked == true)
            {
                ethminercommand += gpu + " -M";
                if (CheckBoxCreateLog.Checked)
                    ethminercommand += LogString;
            }
            else
            if (EnableSimulation.Checked == true)
            {
                ethminercommand += gpu + " -Z";
                if (!String.IsNullOrEmpty(TextBoxSimblock.Text))
                    ethminercommand += " " + TextBoxSimblock.Text;
                if (CheckBoxCreateLog.Checked)
                    ethminercommand += LogString;
            }
            else // Construct a regular (not bench or sim) command line:
            {

                //
                // build a command
                //

                //gpu type and recheck
                ethminercommand += gpu + " --farm-recheck " + TextBoxRecheck.Text + " ";

                //verbosity if needed
                if (ComboBoxVerbosity.SelectedItem.ToString() != "8")  // 8 is default
                    ethminercommand += "-v " + ComboBoxVerbosity.SelectedItem.ToString() + " ";

                //report hasrate and hardware monitor
                if (CheckBoxRH.Checked)
                    ethminercommand += "-RH ";
                if (CheckBoxHWMON.Checked)
                    ethminercommand += "-HWMON ";

                //client and protocol
                ethminercommand += "-SC " + sc + " -SP " + sp + " ";

                //set worktype (-S or -F) AND primary pool:port IF pool:port exists (no shortcircuit - needs true & true)
                if (!String.IsNullOrEmpty(TextBoxPool1.Text) & (!String.IsNullOrEmpty(TextBoxPoolPort1.Text)))
                    ethminercommand += worktype + " " + TextBoxPool1.Text + ":" + TextBoxPoolPort1.Text + " ";

                //fallback/failover pool - do the same as pool1
                if (!String.IsNullOrEmpty(TextBoxPool2.Text) & (!String.IsNullOrEmpty(TextBoxPoolPort2.Text)))
                {
                    ethminercommand += "-FS " + TextBoxPool2.Text + ":" + TextBoxPoolPort2.Text + " ";
                }

                // join account, worker, email to command IF account field has entry AND at least pool1 and port1 fields are entered/exists
                if (!String.IsNullOrEmpty(TextBoxPool1.Text) & !String.IsNullOrEmpty(TextBoxPoolPort1.Text) & !String.IsNullOrEmpty(TextBoxAccount.Text))
                {
                    ethminercommand += "-O " + TextBoxAccount.Text;
                    // // add worker + email if avail
                    if (!String.IsNullOrEmpty(TextBoxWorker.Text))
                        ethminercommand += "." + TextBoxWorker.Text;
                    if (!String.IsNullOrEmpty(TextBoxEmail.Text))
                        ethminercommand += "/" + TextBoxEmail.Text;
                    //no Space added to end of string here!
                }

                //Add extra data on very end (before logging string, though)
                if (!String.IsNullOrEmpty(TextBoxExtra.Text))
                    ethminercommand += " " + TextBoxExtra.Text; // no space - logger has prepended space

                //log it? (log string includes a pre-pended space - keep in mind)
                if (CheckBoxCreateLog.Checked)
                    ethminercommand += LogString;
            }
            // Keep form clean in case of save
            if (String.IsNullOrEmpty(TextBoxPool2.Text))
                TextBoxPoolPort2.Text = "";
            // set the label command and tool tip while we're here
            var full = ethminerexe + " " + ethminercommand;
            LCurrentCommand.Text = full;
            ToolTipEGUI.SetToolTip(LCurrentCommand, full);
            //return the built string. (command WITHOUT "ethminer.exe")
            return ethminercommand;
        }

        private void ButtonSaveProfileName_Click(object sender, EventArgs e)
        {
            // When user clicks 'add' button
            // asks for TextBoxProfileSaveName.Text and save with ButtonSaveProfileName.Click here
            if (!string.IsNullOrEmpty(TextBoxProfileSaveName.Text))
            {
                if (!ListBoxProfiles.Items.Contains(TextBoxProfileSaveName.Text))
                {

                    var profileindex = ListBoxProfiles.SelectedIndex;

                    // save routine here using a deserialed list OBJ. Gave up for now in favor of Linq/Xdoc
                    // - this is still the better way - need to find better way to update/add to/remove from the loaded OBJ while in memory before commit

                    //var obj = Utilities.DeSerializeObject<Profiles>(Filepath); // this is fine - we have the valid xml as an object now

                    // To use this, we need to modifiy object first then serialize it. this wont work as-is..
                    //
                    //Profiles profiles = new Profiles();
                    //Profile work = new Profile()
                    ////obj.ProfileList.Add(new Profile)                    {
                    ////obj.ProfileList.InsertRange(0, "blahName", "name");
                    ////List<Profile> newprofile = new List<Profile>
                    //{
                    //    Name = TextBoxProfileSaveName.Text,
                    //    Worktype = worktype,
                    //    Pool1 = TextBoxPool1.Text,
                    //    Pool1Port = TextBoxPoolPort1.Text,
                    //    Pool2 = TextBoxPool2.Text,
                    //    Pool2Port = TextBoxPoolPort2.Text,
                    //    Wallet = wallet,
                    //    Worker = TextBoxWorker.Text,
                    //    Email = TextBoxEmail.Text,
                    //    Recheck = recheck,
                    //    GPU = gpu,
                    //    HWMON = CheckBoxHWMON.Checked,
                    //    SC = sc,
                    //    SP = sp,
                    //    ReportHashRate = CheckBoxRH.Checked,
                    //    Verbosity = int.Parse(ComboBoxVerbosity.SelectedItem.ToString()),
                    //    ExtraFlags = TextBoxExtra.Text,
                    //    Idle = CheckBoxIdle.Checked,
                    //    IdleMin = idlemin
                    //};
                    //profiles.ProfileList.Add( obj. work);

                    //// serialize / commit
                    //Utilities.SerializeObject(profiles, Filepath);

                    ////////////////////////////////
                    //BEGIN validation before save//
                    ////////////////////////////////
                    //recheck
                    int recheck = 500;
                    int port1 = 0;
                    int port2 = 0;

                    if (!int.TryParse(TextBoxRecheck.Text, out recheck))
                    { MessageBox.Show("Please correct \"--farm-recheck\" value."); return; }

                    //pool1
                    if (String.IsNullOrEmpty(TextBoxPool1.Text))
                    { MessageBox.Show("Please correct primary pool name."); return; }

                    //ports
                    
                    var badportmessage = "Please correct pool port. (Value must be a number between 1025-65000.)";

                    //port1
                    if (!int.TryParse(TextBoxPoolPort1.Text, out port1))
                    {
                        MessageBox.Show(badportmessage);
                        return;
                    }
                    if ((port1 - 1025) * (65000 - port1) < 0)
                    {
                        MessageBox.Show(badportmessage);
                        return;
                    }

                    //port2;
                    if (!String.IsNullOrEmpty(TextBoxPool2.Text))
                    {
                        if (!int.TryParse(TextBoxPoolPort2.Text, out port2))
                        {
                            MessageBox.Show(badportmessage);
                            return;
                        }
                        if ((port2 - 1025) * (65000 - port2) < 0)
                        {
                            MessageBox.Show(badportmessage);
                            return;
                        }
                    }

                    // parse acct/wallet
                    var wallet = "0x";
                    if (!String.IsNullOrEmpty(TextBoxAccount.Text))
                    {
                        if (!CheckWalletAddress())
                        {
                            MessageBox.Show("Please correct your wallet address.\n\nMust be 42 characters long (use with \"0x\").\n\nAllowed characters: \"0x\" \"0-9\" \"a-f\" \"A-F\" )");
                            return;
                        }
                        else
                            wallet = TextBoxAccount.Text;
                    }

                    //email validate using system.net.mail
                    if (!String.IsNullOrEmpty(TextBoxEmail.Text))
                    {
                        try
                        {
                            var emailcheck = new System.Net.Mail.MailAddress(TextBoxEmail.Text);
                        }
                        catch (AmbiguousMatchException)
                        {
                            MessageBox.Show("Please correct email address. Malformed.");
                            return;
                        }
                    }

                    //Extra Flags alert - no validation on textbox
                    if (CheckBoxExtra.Checked == true)
                    {
                        if (!String.IsNullOrEmpty(TextBoxExtra.Text))
                            MessageBox.Show("Please note: You have added extra parameter flags.\nThese will not be validated. Good luck!", "Extra Data Detected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                    }

                    //idle timeout
                    var idlemin = 0;
                    var idlemessage = "Please correct idle minutes.\n(Value must be a number between 1-100.)";
                    if (CheckBoxIdle.Checked)
                    {
                        if (!int.TryParse(TextBoxIdleMins.Text.Trim(), out idlemin))
                        {
                            MessageBox.Show(idlemessage);
                            return;
                        }
                        if ((idlemin - 1) * (100 - idlemin) < 0)
                        {
                            MessageBox.Show(idlemessage);
                            return;
                        }
                    }
                    ////////////////////
                    // END validation //
                    ////////////////////

                    //radio controls to strings/ints (from form not SetCommand() 'command line')
                    SetRadioValues(out string worktype, out string gpu, out int sc, out int sp);

                    var doc = XDocument.Load(Filepath);
                    var newElement =
                      new XElement("Profile",
                      new XAttribute("Name", TextBoxProfileSaveName.Text),
                      new XElement("Worktype", worktype),
                      new XElement("Pool1", TextBoxPool1.Text),
                      new XElement("Pool1Port", TextBoxPoolPort1.Text),
                      new XElement("Pool2", TextBoxPool2.Text),
                      new XElement("Pool2Port", TextBoxPoolPort2.Text),
                      new XElement("Wallet", wallet),
                      new XElement("Worker", TextBoxWorker.Text),
                      new XElement("Email", TextBoxEmail.Text),
                      new XElement("Recheck", recheck),
                      new XElement("GPU", gpu),
                      new XElement("HWMON", CheckBoxHWMON.Checked),
                      new XElement("SC", sc),
                      new XElement("SP", sp),
                      new XElement("ReportHashRate", CheckBoxRH.Checked),
                      new XElement("Verbosity", int.Parse(ComboBoxVerbosity.SelectedItem.ToString())),
                      new XElement("ExtraFlags", TextBoxExtra.Text),
                      new XElement("Idle", CheckBoxIdle.Checked),
                      new XElement("IdleMin", idlemin)
                      );
                    doc.Element("Profiles").Add(newElement);

                    doc.Save(Filepath);

                    MessageBox.Show("Saved.");

                    LoadProfiles();
                    ClearLeft();
                    ClearRight();
                    ListBoxProfiles.SelectedItem = TextBoxProfileSaveName.Text;
                }
                else
                    MessageBox.Show("Save Failed - Duplicate entry. Please correct.\n(Overwrite will be in future release..!)");
            }

        }

        private void ButtonCancelProfileName_Click(object sender, EventArgs e)
        {
            ClearLeft();
            ClearRight();
        }

        private void ListBoxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupButtons();
        }

        private void radioStratumMode_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void radioFarmMode_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void TextBoxRecheck_TextChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void TextBoxPool1_TextChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void TextBoxPool2_TextChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void TextBoxAccount_TextChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void TextBoxWorker_TextChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void RadioButtonOpenCL_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void RadioButtonCUDA_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void RadioButtonMixedCards_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void CheckBoxHWMON_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void RadioButtonSC1_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void RadioButtonSC2_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void RadioButtonSP0_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void RadioButtonSP1_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void RadioButtonSP2_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void CheckBoxRH_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void CheckBoxExtra_CheckedChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void TextBoxExtra_TextChanged(object sender, EventArgs e)
        {
            if (CheckBoxExtra.Checked == true)
                SetCommand();
        }

        private void benchmarkseconds_TextChanged(object sender, EventArgs e)
        {
            // not implemented yet
        }

        private void benchmarktrialsecs_TextChanged(object sender, EventArgs e)
        {
            // not implemented yet
        }

        private void benchmarktrials_TextChanged(object sender, EventArgs e)
        {
            // not implemented yet
        }

        private void simblock_TextChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void ComboBoxVerbosity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCommand();
        }

        private void SetRadioValues(out string worktype, out string gpu, out int sc, out int sp)
        {
            //defaults for outs just in case:
            worktype = "-S";
            gpu = "-G";
            sc = 1;
            sp = 0;

            if (RadioFarmMode.Checked == true)
                worktype = "-F";
            if (RadioButtonOpenCL.Checked == true)
                gpu = "-G";
            if (RadioButtonCUDA.Checked == true)
                gpu = "-U";
            if (RadioButtonMixedCards.Checked == true)
                gpu = "-X";
            if (RadioButtonSC1.Checked == true)
                sc = 1;
            if (RadioButtonSC2.Checked == true)
                sc = 2;
            if (RadioButtonSP0.Checked == true)
                sp = 0;
            if (RadioButtonSP1.Checked == true)
                sp = 1;
            if (RadioButtonSP2.Checked == true)
                sp = 2;
        }

        private void PopulateProfile()
        {
            if (ListBoxProfiles.SelectedItem != null)
            {
                //ClearRight();
                var profileindex = ListBoxProfiles.SelectedIndex;
                var obj = Utilities.DeSerializeObject<Profiles>(Filepath);
                var worktype = obj.ProfileList[profileindex].Worktype;

                switch (worktype)
                {
                    case "-F":
                        RadioFarmMode.Checked = true;
                        break;
                    case "-S":
                        RadioStratumMode.Checked = true;
                        break;
                }
                if (obj.ProfileList[profileindex].Worktype == "-S")
                {
                    RadioStratumMode.Checked = true;
                    RadioFarmMode.Checked = false;
                }
                else
                {
                    RadioStratumMode.Checked = false;
                    RadioFarmMode.Checked = true;
                }
                var gpu = obj.ProfileList[profileindex].GPU;
                switch (gpu)
                {
                    case "-X":
                        RadioButtonMixedCards.Checked = true;
                        break;
                    case "-U":
                        RadioButtonCUDA.Checked = true;
                        break;
                    case "-G":
                        RadioButtonOpenCL.Checked = true;
                        break;
                }
                CheckBoxHWMON.Checked = obj.ProfileList[profileindex].HWMON;
                CheckBoxRH.Checked = obj.ProfileList[profileindex].ReportHashRate;
                TextBoxPool1.Text = obj.ProfileList[profileindex].Pool1.ToString();
                TextBoxPoolPort1.Text = obj.ProfileList[profileindex].Pool1Port.ToString();
                TextBoxPool2.Text = obj.ProfileList[profileindex].Pool2.ToString();
                TextBoxPoolPort2.Text = obj.ProfileList[profileindex].Pool2Port.ToString();
                TextBoxAccount.Text = obj.ProfileList[profileindex].Wallet.ToString();
                TextBoxWorker.Text = obj.ProfileList[profileindex].Worker.ToString();
                TextBoxEmail.Text = obj.ProfileList[profileindex].Email.ToString();
                TextBoxRecheck.Text = obj.ProfileList[profileindex].Recheck.ToString();
                //
                SetupButtons();
                SetCommand();
                EnableGroups();
                TextBoxProfileSaveName.Text = ListBoxProfiles.SelectedItem.ToString();
                LabelProfileNameLoaded.Text = ListBoxProfiles.SelectedItem.ToString();
                EnableLeftEdit();
                this.ActiveControl = RadioStratumMode;

            }
        }

        private void ButtonRemoveProfile_Click(object sender, EventArgs e)
        {
            // need to use deserialer under Utilities Class but need to figure out how to modify the OBJ in memory. For now we use XmlDoc/Linq
            XmlDocument doc = new XmlDocument();
            doc.Load(Filepath);
            XmlNode node = doc.SelectSingleNode(String.Format("//Profiles/Profile[@Name='{0}']", ListBoxProfiles.SelectedItem.ToString()));
            if (node != null)
            {
                XmlNode parent = node.ParentNode;
                parent.RemoveChild(node);

                string newXML = doc.OuterXml;

                doc.Save(Filepath);
                LoadProfiles();
                ListBoxProfiles.SelectedIndex = -1;
            }

        }

        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        private void ButtonStartMining_Click(object sender, EventArgs e)
        {
            ButtonStartMining.Text = "Stop Miner";
            ButtonStartMining.ForeColor = Color.Red;
            //System.Diagnostics.Process.Start(String.Format(@"cmd.exe", @"/k {0}", ethminerpath + ethminercommand));
            try  // https://stackoverflow.com/questions/1275403/run-a-console-application-from-a-windows-form
            {
                var startcommand = String.Format(" /c \"{0}\\{1}\" {2}", ethminerpath, ethminerexe, ethminercommand);
                //powershell
                //var startcommand = " &" + "\'" + ethminerpath + "\\" + ethminerexe + "\' " + ethminercommand;
                //debug:
                //var sb = new StringBuilder();

                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = false;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.ErrorDialog = false;
                //proc.StartInfo.RedirectStandardOutput = false;
                //proc.StartInfo.RedirectStandardError = false;
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.Arguments = startcommand;
                //if (CheckBoxCreateLog.Checked)
                //{
                //    proc.StartInfo.Arguments += LogString;
                //}
                if (CheckBoxNoWarnings.Checked == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Command:  cmd\n" + startcommand, "Please Confirm Command", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                    {
                        ButtonStartMining.Text = "Start Miner";
                        ButtonStartMining.ForeColor = Color.Green;
                        ButtonStartMining.Enabled = true;
                        return;
                    }
                        
                }

                // hookup the eventhandlers to capture the data that is received
                //proc.OutputDataReceived += (crap, args) => sb.AppendLine(args.Data);
                //proc.ErrorDataReceived += (crap, args) => sb.AppendLine(args.Data);
                var consoletitle = "";
                if ((EnableBenchmark.Checked == true) || (EnableSimulation.Checked == true))
                    consoletitle = " ethminerGUI - Running Test";
                else
                    consoletitle = " ethminerGUI - " + TextBoxPool1.Text + ":" + TextBoxPoolPort1.Text + "  (Mining!)";

                proc.Start();
                // start our event pumps
                //proc.BeginOutputReadLine();
                //proc.BeginErrorReadLine();

                // https://stackoverflow.com/a/45214485/503621 :
                SpinWait.SpinUntil(delegate
                {
                    return proc.MainWindowHandle != IntPtr.Zero;
                });
                SetWindowText(proc.MainWindowHandle, consoletitle );

                //txtOutput.Text += proc.StandardOutput.ReadToEnd().Replace("\n", "\r\n");
                //txtOutput.Text += proc.StandardError.ReadToEnd().Replace("\n", "\r\n");
                proc.WaitForExit();
                SetupButtons();
                //txtOutput.Refresh();

            }
            catch (AmbiguousMatchException)
            {
                //txtOutput.Text = ex.Message;
                MessageBox.Show("Miner issue - Exception thrown.");
            }
        }

        private void eTHMINERHelpFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelpFlags HelpForm = new FormHelpFlags();
            HelpForm.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelpAbout HelpFormAbout = new FormHelpAbout();
            HelpFormAbout.ShowDialog();
        }

        private void setEthminerexeLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "ethminerGUI - Settings | Set Location";
            openFileDialog1.DefaultExt = "exe";
            openFileDialog1.Filter = "EXE Files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {
                ethminercommand_alt = openFileDialog1.SafeFileName;
                ethminerexe = openFileDialog1.SafeFileName;
                ethminerpath = Path.GetDirectoryName(openFileDialog1.FileName);
                SetCommand();
            }
        }

        private void editProfilesXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Filepath);
        }

        public void CreateXMLFile()
        {
            if (!File.Exists(Filepath))
            {
                //Populate with data here if necessary, then save to make sure it exists
                var xmlFile = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("XML File for storing Profiles"));
                xmlFile.Add(new XElement("Profiles"));
                xmlFile.Save(Filepath);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ethminercommand_alt = "";
            ethminerexe = "ethminer.exe";
            ethminerpath = Application.StartupPath;
            SetCommand();
        }

        private void LoadApplicationDefaultsEthminerGUI()
        {
            //Save user settings from project properties on load event (all props are set to user/roaming):
            this.ComboBoxVerbosity.SelectedItem = Properties.Settings.Default.Verbosity.ToString();
            this.CheckBoxIdle.Checked = Properties.Settings.Default.StartOnIdleEnabled;
            this.TextBoxIdleMins.Text = Properties.Settings.Default.StartOnIdleMinutes.ToString();
            this.CheckBoxExtra.Checked = Properties.Settings.Default.ExtraFlagsEnabled;
            this.TextBoxExtra.Text = Properties.Settings.Default.ExtraFlags;
            this.CheckBoxCreateLog.Checked = Properties.Settings.Default.LogEnabled;
            this.CheckBoxNoWarnings.Checked = Properties.Settings.Default.WarnBeforeMining;
        }
        private void SaveApplicationDefaultsEthminerGUI()
        {
            //Save user settings from project properties on load event (all props are set to user/roaming):
            Properties.Settings.Default.Verbosity = int.Parse(this.ComboBoxVerbosity.SelectedItem.ToString());
            Properties.Settings.Default.StartOnIdleEnabled = this.CheckBoxIdle.Checked;
            Properties.Settings.Default.StartOnIdleMinutes = Int32.TryParse(this.TextBoxIdleMins.Text, out int x) ? x : x = 0;
            Properties.Settings.Default.ExtraFlagsEnabled = this.CheckBoxExtra.Checked;
            Properties.Settings.Default.ExtraFlags = this.TextBoxExtra.Text;
            Properties.Settings.Default.LogEnabled = this.CheckBoxCreateLog.Checked;
            Properties.Settings.Default.WarnBeforeMining = this.CheckBoxNoWarnings.Checked;
            // Save it all if save on exit is true
            Properties.Settings.Default.Save();
        }

        private void saveEXEConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveApplicationDefaultsEthminerGUI();
        }

        private void defaultMISCSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ComboBoxVerbosity.SelectedItem = "8";
            this.CheckBoxIdle.Checked = false;
            this.TextBoxIdleMins.Text = "";
            this.CheckBoxExtra.Checked = false;
            this.TextBoxExtra.Text = "";
            this.CheckBoxCreateLog.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckBoxSaveOnExit.Checked)
                SaveApplicationDefaultsEthminerGUI();
        }


        private bool CheckWalletAddress()
        {
            Regex validInput = new Regex(@"^(0x)?[0-9a-f]+$", RegexOptions.IgnoreCase);
            if (validInput.IsMatch(TextBoxAccount.Text) & (TextBoxAccount.TextLength == 42)) // both need to be true. no shortcircuit. needs certain chars & "0x"+40 (42)
                return true;
            else
                return false;
        }

        // to do: move these repetitions to  utilities (public/static as form extension)

        private void TextBoxPoolPort1_KeyPress(object sender, KeyPressEventArgs e)
        { // Numbers only = https://stackoverflow.com/a/463335/503621  --- Need to really use NumericUpDown Textbox/Number Class
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TextBoxPoolPort2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TextBoxSimblock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
