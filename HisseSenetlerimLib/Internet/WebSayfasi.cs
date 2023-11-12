using HtmlAgilityPack;

namespace HisseSenetlerimLib.Internet
{
    public class WebSayfasi
    {
        public List<HisseSenedi> Hisseler { get; private set; } = new List<HisseSenedi>();
        private readonly HtmlDocument _belge = new HtmlDocument();
        private readonly Xpath _xpath = new Xpath();

        public void HtmlYukle()
        {
            Indir();

            _belge.Load(Environment.CurrentDirectory + @"\canli-borsa.html");

            int sira = 1;
            while (true)
            {
                var dugumler = _belge.DocumentNode.SelectNodes(_xpath.Satir(sira++));
                if (dugumler != null)
                    foreach (HtmlNode row in dugumler)
                        Ekle(row.SelectNodes("td"));
                else
                    break;
            }
        }

        private async void Indir()
        {
            Uri adres = new Uri("https://www.getmidas.com/canli-borsa/");

            if (Baglanti.InternetVarMi())
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string icerik = await httpClient.GetStringAsync(adres);

                    using (FileStream dosyaAkis = new FileStream("canli-borsa.html", FileMode.Create))
                    {
                        using (StreamWriter yaz = new StreamWriter(dosyaAkis))
                            await yaz.WriteLineAsync(icerik);
                    }
                }
            }
        }

        private void Ekle(HtmlNodeCollection hucreler)
        {
            for (int satir = 0; satir < 1; ++satir)
            {
                int sayac = 0;
                Hisseler.Add(new HisseSenedi
                {
                    Hisse = hucreler[sayac++].InnerText.Trim(),
                    Son = hucreler[sayac++].InnerText.Trim(),
                    Alis = hucreler[sayac++].InnerText.Trim(),
                    Satis = hucreler[sayac++].InnerText.Trim(),
                    Fark = hucreler[sayac++].InnerText.Trim(),
                    EnDusuk = hucreler[sayac++].InnerText.Trim(),
                    EnYuksek = hucreler[sayac++].InnerText.Trim(),
                    Aof = hucreler[sayac++].InnerText.Trim(),
                    HacimLira = hucreler[sayac++].InnerText.Trim(),
                    HacimLot = hucreler[sayac].InnerText.Trim()
                });
            }
        }
    }
}