/* 2- Method Overloading ile Matematik Sınıfı
   📌 Görev:
   - Matematik işlemleri için bir sınıf oluşturun.
   - Toplama,Çarpma işlemleri için method overloading uygulayın.
   - İki ve üç parametreli versiyonlarını oluşturun.
   - Farklı veri tiplerinde (int, double) kullanımı gösterin.
   
   */
   
   using System;
  


   class Islemler
   {
      public Islemler()
      {
         Console.WriteLine("Matematik işlemlerimiz burada:");
      }
      
      public int toplama(int a, int b)
      {
         return a + b;
      }

      public double toplama(double a, double b)
      {
         return a + b;
      } 
      
      public int toplama(int a, int b, int c)
      {
         return a + b + c;
      }
      
      public double toplama(double a, double b, double c)
      {
         return a + b + c;
      }
      public int carpma(int a, int b)
      {
         return a * b;
      }
      
      public double carpma (double a, double b)
      {
         return a * b;
      } 

      public int carpma(int a, int b, int c)
      {
         return a * b * c;
      }
      
      public double carpma (double a, double b, double c)
      {
         return a * b * c;
      }
   }

   

   class Program
   {
      static void Main(string[] args)
      { Islemler nsn = new Islemler();
      Console.WriteLine(nsn.toplama(6,5));
      Console.WriteLine(nsn.toplama(23543,3456));
      Console.WriteLine(nsn.toplama(5,9,0));
      Console.WriteLine(nsn.toplama(5678,678,89));
      
      
      Console.WriteLine(nsn.carpma(9,5));
      Console.WriteLine(nsn.carpma(445,3453));
      Console.WriteLine(nsn.carpma(34532,6535));
      Console.WriteLine(nsn.carpma(5,75654));
      
      
      
         
      }
   }
   