using System;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ethminerGUI
{
    public partial class FormHelpAbout : Form
    {
        public FormHelpAbout()
        {
            InitializeComponent();
        }

        private void FormHelpAbout_Load(object sender, EventArgs e)
        {
            SetupContextCopy();
            linkLabelDiscord.LinkBehavior   = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabelWebsite.LinkBehavior   = System.Windows.Forms.LinkBehavior.NeverUnderline;
            LinkLabelEthminer.LinkBehavior  = System.Windows.Forms.LinkBehavior.NeverUnderline;
            LinkLabelGNULink.LinkBehavior   = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        private void LinkLabelWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bmatthewshea/ethminerGUI");
            linkLabelWebsite.LinkVisited = false;
        }

        private void LinkLabelDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/MFzuyNs");
            linkLabelDiscord.LinkVisited = false;
        }

        private void LinkLabelGNULink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ethereum-mining/ethminer/blob/master/LICENSE");
            LinkLabelGNULink.LinkVisited = false;
        }

        private void LinkLabelGNULink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://opensource.org/licenses/GPL-3.0");
            LinkLabelGNULink.LinkVisited = false;
        }

        private void LinkLabelEthminer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ethereum-mining/ethminer/releases");
            LinkLabelGNULink.LinkVisited = false;
        }

        private void SetupContextCopy()
        {
            TextBoxEthereum.AddContextMenu();
            TextBoxETC.AddContextMenu();
            TextBoxXMR.AddContextMenu();
            TextBoxLTC.AddContextMenu();
            TextBoxBTC.AddContextMenu();
        }

        private void TextBoxEthereum_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxEthereum.SelectBeforeContext(); // 'before context '(Copy Address)' part doesnt work yet ;-) - what does: selectall on 1 left-click
        }

        private void TextBoxETC_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxETC.SelectBeforeContext();
        }

        private void TextBoxXMR_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxXMR.SelectBeforeContext();
        }

        private void TextBoxLTC_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxLTC.SelectBeforeContext();
        }

        private void TextBoxBTC_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxBTC.SelectBeforeContext();  
        }


    }
}
