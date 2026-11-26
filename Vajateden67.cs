namespace Vajateden6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // oseba oseba1 = new oseba("Urh", "Bukovec", 21, "rdeča");
            // oseba oseba2 = new oseba("Luka", "Greznik", 20, "modra");

            //oseba1.ime = "Urh";
            //oseba2.ime = "Luka";
            //oseba2.priimek = "Greznik";

            //oseba1.predstaviSe();
            //oseba2.predstaviSe();

            //Radio mojRadio = new Radio(true, "Sony");
            //mojRadio.Ugasni();
            //mojRadio.PoslusajRadio();

            //TV mojTV = new TV(false, "Samsung");
            //mojTV.Prizgi();
            //mojTV.GledajTV();

            //Pes pes = new Pes("Piko", 6);
            //Console.WriteLine($"{pes.ime} je bil {pes.starost} star.");
            //pes.KreirajZvok();
            //pes.igra();
            //pes.Eat();

            //Objava objava1 = new Objava("To je prva objava", true, "Miroslav Strniša");
            //Console.WriteLine(objava1.ToString());
            //ObjavaSlike objavaSlike1 = new ObjavaSlike("To je druga objava","Miroslav Strniša", "http://www.testtest.si/", true);
            //Console.WriteLine(objavaSlike1.ToString());

            Objava objava1 = new Objava("Hvala za vse.", true, "Miroslav Strniša");
            Console.WriteLine(objava1.ToString());

            ObjavaSlike objavaSlike1 = new ObjavaSlike("Preveri mojo novo sliko",
                "Miroslav Strniša", "http://miroslavstrnisa.si", true);
            Console.WriteLine(objavaSlike1.ToString());

            VideoObjava video1 = new VideoObjava("Moj video", "Miroslav Strniša", "http://video.si", true, 30);
            Console.WriteLine(video1.ToString());

            Console.Read();
        }
    }
}

