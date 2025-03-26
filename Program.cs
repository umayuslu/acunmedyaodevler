// See https://aka.ms/new-console-template for more information

/*Ad
   Bir Araba (Car) sınıfı oluşturun. Bu sınıf içinde aşağıdaki özellikler yer almalıdır:
   
   Marka (string) → Arabanın markasını tutar.
   Model (string) → Arabanın modelini tutar.
   Benzin Harcaması (FuelConsumption) (double) → 100 km başına harcanan yakıt miktarını tutar.
   Toplam Mesafe (TotalDistance) (double) → Arabanın toplamda kaç km yol gittiğini tutar.
   Daha sonra, bir List<Car> oluşturup en az 3 farklı araba ekleyin.
   Son olarak, her arabanın toplamda ne kadar benzin harcadığını hesaplayarak ekrana yazdırın. */
   
class Araba
{
   public string Marka { get; set; }
   public string Model { get; set; }
   public double Benzinharcamasi { get; set; }
   public double Totalmesafe { get; set; }

   public double toplambenzintuketimi()
   {
      return (Totalmesafe/100)* Benzinharcamasi;
   
}



}

class Program
{
   static void Main(string[] args)
   {

      List<Araba> arabalar = new List<Araba>()
      {
         new Araba { Marka = "Toyota", Model = "Corolla", Benzinharcamasi = 6.5, Totalmesafe = 500 },
         new Araba { Marka = "BMW", Model = "320i", Benzinharcamasi = 8.0, Totalmesafe = 800 },
         new Araba { Marka = "Ford", Model = "Focus", Benzinharcamasi = 7.2, Totalmesafe = 600 }
      };

      foreach (var araba in arabalar)
      {
         Console.WriteLine($"Marka:{araba.Marka}  Model:{araba.Model}   Benzin Harcaması:{araba.Benzinharcamasi}    Toplam Mesafe:{araba.Totalmesafe}   Toplam Benzin Tüketimi:{araba.toplambenzintuketimi()}");
      }
   }
}