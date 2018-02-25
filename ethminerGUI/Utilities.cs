using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ethminerGUI
{
    public static class Utilities
    {
        /// <summary>
        /// Serializes an object. https://stackoverflow.com/a/6115782/503621
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <param name="fileName"></param>
        public static void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (AmbiguousMatchException)
            {
                //Log exception here
            }
        }


        /// <summary>
        /// Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (AmbiguousMatchException)
            {
                //Log exception here
            }

            return objectOut;
        }

        public static void SelectBeforeContext(this TextBox tb)
        {
            tb.SelectAll();  // Does not select before context menu below. Need to fix. Selects fine though, on left-click.
        }

        public static void AddContextMenu(this TextBox tb)
        {
            if (tb.ContextMenuStrip == null)
            {
                ContextMenuStrip cms = new ContextMenuStrip { ShowImageMargin = false };
                ToolStripMenuItem CopyMe = new ToolStripMenuItem("Copy Address");
                CopyMe.Click += (sender, e) => tb.Copy();
                cms.Items.Add(CopyMe);
                tb.ContextMenuStrip = cms;
            }
        }






    }
}
