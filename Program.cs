namespace SUT23_Övning_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country c1 = new Country()
            {
                Name = "Sparta",
                Code = 2,
                Capital = "Pizzahut"
            };
            Country c2 = new Country()
            {
                Name = "Andalusien",
                Code = 3,
                Capital = "Maraca"
            };
            Country c3 = new Country()
            {
                Name = "Pompeius",
                Code = 4,
                Capital = "Laois"
            };
            Country c4 = new Country()
            {
                Name = "Horeec",
                Code = 5,
                Capital = "Haed"
            };
            Country c5 = new Country()
            {
                Name = "Mororo",
                Code = 1,
                Capital = "Szaiv"
            };

            List<Country> countries = new List<Country>();
            countries.Add(c1);
            countries.Add(c2);
            countries.Add(c3);
            countries.Add(c4);
            countries.Add(c5);

            Console.WriteLine("Enter Country code for more information:");
            int choice = Convert.ToInt32(Console.ReadLine());
            Country result = countries.Find(e => e.Code == choice);
            if (choice > 0 && choice < 6)
            {
                
                Console.WriteLine("Country name: {0] \nCountry Code: {1} \n Country Capital: {2}", result.Name, result.Code, result.Capital);
            }
            else
            {
                Console.WriteLine("Must be between numbers 1-5");
            }

            Console.ReadKey();

        }
    }
}