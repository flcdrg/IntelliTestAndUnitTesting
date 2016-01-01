using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelliTestAndUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {


            var repository = new PeopleRepository();

            var names = repository.GetDistinctNames();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            var geography = repository.GetPersonGeography("David");

            if (geography != null)
            {
                var service = new MapService();

                service.GetMapImage(@"c:\tmp\image.jpg", geography.Latitude.Value, geography.Longitude.Value);
            }


            ITaxService tax = new TaxService();

            var taxPayable = tax.GetTaxPayable(123456);

            Console.WriteLine($"Total tax payable: {taxPayable:C0}");

            Console.ReadLine();
        }
    }
}
