namespace HisseSenetlerimLib.Internet
{
    public class Xpath
    {
        public string Satir(int sayi)
        {
            return $"/html/body/div[1]/div/div/div/div[6]/table/tbody/tr[{sayi}]";
        }
    }
}