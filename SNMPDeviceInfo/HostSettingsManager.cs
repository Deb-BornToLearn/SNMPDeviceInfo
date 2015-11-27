using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Collections;

namespace SNMPDeviceInfo
{
    public class HostSettingsManager : IEnumerable<ISNMPHostSettings>, INotifyPropertyChanged, INotifyCollectionChanged, IListSource
    {
        Dictionary<string, SNMPHostSettings> hostSettings;

        #region Constructors

        public HostSettingsManager()
        {

        }

        public HostSettingsManager(string hostSettingsFile)
        {
            hostSettings = new Dictionary<string, SNMPHostSettings>();
            LoadSettingsFromXMLFile(hostSettingsFile);
        }

        #endregion Constructors

        public ISNMPHostSettings Addv12Settings(SNMPConstants.SNMPVersion version, string ipOrHostname, string dispName, string readCommunity, string writeCommunity)
        {
            SNMPHostSettings hs = new SNMPHostSettings();
            hs.IpOrHostname = ipOrHostname;
            hs.SnmpVersion = version;
            hs.DisplayName = dispName;
            hs.ReadCommunity = readCommunity;
            hs.WriteCommunity = writeCommunity;
            string id = Guid.NewGuid().ToString();

            hostSettings.Add(id, hs);

            NotifyCollectionChanged(NotifyCollectionChangedAction.Add);

            return hs;
        }

        #region Implement IEnumerable<ISNMPHostSettings>

        public IEnumerator<ISNMPHostSettings> GetEnumerator()
        {
            return hostSettings.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return hostSettings.Values.GetEnumerator();
        }

        #endregion Implement IEnumerable<ISNMPHostSettings>

        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion Implement INotifyPropertyChanged

        #region Implement INotifyCollectionChanged

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private void NotifyCollectionChanged(NotifyCollectionChangedAction a)
        {
            CollectionChanged(this, new NotifyCollectionChangedEventArgs(a));
        }

        #endregion Implement INotifyCollectionChanged


        public void LoadSettingsFromXMLFile(string hostSettingsFile)
        {
            XmlReaderSettings xmlsettings = new XmlReaderSettings();
            xmlsettings.IgnoreWhitespace = true;

            using (XmlReader reader = XmlReader.Create(hostSettingsFile, xmlsettings))
            {
                reader.MoveToContent();

                reader.ReadStartElement("SNMPHostSettings");

                while (reader.Name == "Host")
                {
                    XElement el = (XElement)XNode.ReadFrom(reader);
                    SNMPHostSettings hs = SNMPHostSettings.fromXElement(el);
                    hostSettings[hs.Id] = hs;
                }

                reader.ReadEndElement();
            }
        }

        bool IListSource.ContainsListCollection
        {
            get
            {
                return true;
            }
        }

        IList IListSource.GetList()
        {
            return hostSettings.Values.ToList<ISNMPHostSettings>();
        }
    }
}
