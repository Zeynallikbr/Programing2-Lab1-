namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa Malin adini daxil edin: ");
            string productName = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa malin sayini daxil edin: ");
            int productCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa Malin qiymetini daxil edin: ");
            int poductSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa malin istehsal tarixini daxil edin: ");
            decimal prductType = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa Malin Halal olub olmadigini daxil edin: ");
            string halalOrHaram = Console.ReadLine();
            Console.WriteLine("Mala neçe % edirim edilir ? ve ya yox edilmirse {0} daxil et: ");
            decimal productDiscount = decimal.Parse(Console.ReadLine());
            if (productDiscount > 0)
            {
                productDiscount = (poductSalary * productDiscount / 100);

            }
            else
            {
                Console.WriteLine(productDiscount);
            }
            Console.WriteLine("Malin adi: "+productName);
            Console.WriteLine("Malin sayi: "+productCount);
            Console.WriteLine("Malin qiymeti:" + poductSalary+ " AZN");
            Console.WriteLine("Malin istehsal tarixi: "+ prductType);
            Console.WriteLine("Halal yoxsa Haram" + halalOrHaram);
            Console.WriteLine($"edirim edilmeyi: {productDiscount}");
        }
    }
}
