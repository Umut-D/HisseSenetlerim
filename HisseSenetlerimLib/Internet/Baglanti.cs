namespace HisseSenetlerimLib.Internet
{
    public static class Baglanti
    {
        public static bool InternetVarMi()
        {
            const string webSayfasi = "https://google.com/";

            try
            {
                using (HttpClient webBaglanti = new HttpClient())
                {
                    using (HttpResponseMessage response = webBaglanti.GetAsync(webSayfasi).Result)
                    {
                        return response.IsSuccessStatusCode;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}