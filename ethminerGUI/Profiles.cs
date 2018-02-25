using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ethminerGUI
{
    //[Serializable, XmlRoot("Profiles"), XmlType("profiles")]
    public class Profiles
    {
        private List<Profile> _profiles = new List<Profile>();

        [XmlElement("Profile")]
        public List<Profile> ProfileList
        {
            get { return _profiles; }
        }
    }

    //[Serializable]
    public class Profile
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlElement]
        public string Worktype { get; set; }

        [XmlElement]
        public string Pool1 { get; set; }

        [XmlElement]
        public string Pool1Port { get; set; }

        [XmlElement]
        public string Pool2 { get; set; }

        [XmlElement]
        public string Pool2Port { get; set; }

        [XmlElement]
        public string Wallet { get; set; }

        [XmlElement]
        public string Worker { get; set; }

        [XmlElement]
        public string Email { get; set; }

        [XmlElement]
        public int Recheck { get; set; }

        [XmlElement]
        public string GPU { get; set; }

        [XmlElement]
        public bool HWMON { get; set; }

        [XmlElement]
        public int SC { get; set; }

        [XmlElement]
        public int SP { get; set; }

        [XmlElement]
        public bool ReportHashRate { get; set; }

        [XmlElement]
        public int Verbosity { get; set; }

        [XmlElement]
        public string ExtraFlags { get; set; }

        [XmlElement]
        public bool Idle { get; set; }

        [XmlElement]
        public int IdleMin { get; set; }
    }

}
