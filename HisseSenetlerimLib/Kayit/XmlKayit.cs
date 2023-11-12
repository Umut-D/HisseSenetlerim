using System.Xml.Serialization;
using HisseSenetlerimLib.Kayit.Arayuzler;

namespace HisseSenetlerimLib.Kayit
{
    public class XmlKayit : IKaydet, IAc
    {
        private readonly string _xmlDizin = Environment.CurrentDirectory + @"\yatirimlar.xml";

        public void Kaydet(List<Yatirim>? yatirimlar)
        {
            XmlSerializer xmlSerialize = new XmlSerializer(yatirimlar?.GetType());

            using (FileStream xmlKayit = new FileStream(_xmlDizin, FileMode.OpenOrCreate))
                xmlSerialize.Serialize(xmlKayit, yatirimlar);
        }

        public List<Yatirim>? Ac()
        {
            List<Yatirim>? yatirimlar = new List<Yatirim>();
            XmlSerializer xmlSerialize = new XmlSerializer(yatirimlar.GetType());

            using (FileStream xmlOku = new FileStream(_xmlDizin, FileMode.OpenOrCreate))
            {
                if (xmlOku.Length != 0)
                    yatirimlar = (List<Yatirim>?)xmlSerialize.Deserialize(xmlOku);
            }

            return yatirimlar;
        }
    }
}