namespace C__Projeleri_5_Karakter_Tersten_Yazdırma;
public class Konsol_Islemleri
{
    public void GirisMesaji()
    {
        Console.WriteLine("Lütfen girmek istediğiniz cümleleri aralarında boşluk olacak şekilde yazınız: ");
    }
    public string[] CumleleriAlma()
    {
        string cumleler = Console.ReadLine();
        return cumleler.Split(" ");

    }

}