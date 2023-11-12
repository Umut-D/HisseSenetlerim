using System.Text;
using HisseSenetlerimLib.Kayit.Arayuzler;

namespace HisseSenetlerimLib.Kayit
{
    public class TxtKayit : IKaydet
    {
        private readonly string _txtDizin = Environment.CurrentDirectory + @"\yatirimlar.txt";

        public void Kaydet(List<Yatirim>? yatirimlar)
        {
            using (FileStream dosyaAkis = new FileStream(_txtDizin, FileMode.OpenOrCreate))
            {
                dosyaAkis.SetLength(0);

                using (StreamWriter yaz = new StreamWriter(dosyaAkis, Encoding.UTF8))
                {
                    if (yatirimlar == null) 
                        return;
                    
                    foreach (Yatirim yatirim in yatirimlar)
                        yaz.WriteLine(yatirim.HisseBilgisi);
                }
            }
        }
    }
}