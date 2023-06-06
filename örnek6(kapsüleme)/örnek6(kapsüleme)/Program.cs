
namespace örnek6_kapsüleme_;
class Isci
{
    public int KimlikNo { get; set; }//burdada neden kapsüleme yaptık diye sorarsan bunu sebebi uml diyagramında baş harfleri büyük harfle yazılmış
    public int Maas { get; set; }//bunu daha uzunda kulanabilirsin returnlü vayda valueli fakat buda aynı anlama geciyo zaten (auto implemented)
    public KimlikBilgisi kimlik { get; set; } = new KimlikBilgisi();//bunu yaparak composition yaptık ama bunun hemen altındaki agrigation du   
    //public KimlikBilgisi kimlik { get; set; }//burada buna (kimlik) yapmamızın sebebi aşağıda cağırmak için yani KimlikBilgisi'i aşağıda cağırabilme için

}
class KimlikBilgisi
{
   public ulong TCKimlikNo { get; set; }
   public string Ad { get; set; }
   public string Soyad { get; set; }
   public string DoğumYeri { get; set; }
   public DateTime DoğumTarihi { get; set; }
    public string strAdSoyad;//bunu yazma sebebim aşağıdaki nesneyi atamak olmam zaten aşağıdaki nesne biir agregation composition olabilmesi için new demek lazımdı 
   public string AdSoyad //burası yanlıs okunabilir değer atanamaz
    {
        get { strAdSoyad= Ad.ToUpper() +  Soyad.ToUpper();
            return strAdSoyad;
        }
    }



}
class test
{
    static void Main(string[] args)
    {

        List<Isci> ıscis = new List<Isci>();
        int hesap;//bunu burada decimal vermek zorundayım cünkü maas decimal ce cevrilemez başka bir şeye
        double tammaşş;
        Boolean durum = true;


        Isci is1= new Isci();
        Console.Write("Ad : ");
         is1.kimlik.Ad =Console.ReadLine();
        Console.Write("Soyat : ");
        is1.kimlik.Soyad = Console.ReadLine();
        Console.Write(" Kimlik Numaranız : ");
        is1.KimlikNo=Convert.ToInt32(Console.ReadLine());
        Console.Write("TC Kimlik Numaranız : ");
        is1.kimlik.TCKimlikNo= (ulong)Convert.ToInt64(Console.ReadLine());//burada girilen değeri unlog'a cevirdik yani zorlama var
        Console.Write("Doğum Yeri : ");
        is1.kimlik.DoğumYeri = Console.ReadLine();
        Console.Write("Doğum Tarihi : ");
        is1.kimlik.DoğumYeri = Console.ReadLine();
        Console.Write("Maaşınız : ");
        is1.Maas = Convert.ToInt32(Console.ReadLine());

 
        if (is1.Maas < 6000) {
             hesap=(is1.Maas /6);
            Console.WriteLine("Maşınızın  " +hesap +"TL  sigorta bedeli düşecektir");
            tammaşş = (double)Convert.ToInt16(is1.Maas - hesap); 
        }
        else if (is1.Maas < 10000) {
            hesap =(is1.Maas /10);
            Console.WriteLine("Maşınızdan  "+hesap+ "TL  sigorta bedeli düşecektir");
            tammaşş = (double)Convert.ToInt16(is1.Maas - hesap);
        }
        else if(is1.Maas < 20000) {
            hesap=(is1.Maas / 13);
            Console.WriteLine("Maşınızdan  " + hesap + "TL  sigorta bedeli düşecektir");
            tammaşş = (double)Convert.ToInt16(is1.Maas - hesap);
        }
        else if (is1.Maas < 40000)
        {
            hesap = (is1.Maas / 15);
            Console.WriteLine("Maşınızdan  " + hesap + "TL  sigorta bedeli düşecektir");
            tammaşş = (double)Convert.ToInt16(is1.Maas - hesap);
        }

         
         
        ıscis.Add(is1);

        foreach (Isci  item in ıscis )//listeyi boşaltmak için
        {
            Console.WriteLine("AdSoyadın : " + item );
            Console.WriteLine("Kimlik Numaranız : " +item);
            Console.WriteLine("TC Kİmlik Numaranız : " + item) ;
             

        }

        

        Console.ReadLine();

    }
}

