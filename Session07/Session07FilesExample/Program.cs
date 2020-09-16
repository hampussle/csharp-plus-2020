using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Session07FilesExample
{   
    class Program
    {
        const string _separator = ";";
        static void Main(string[] args)
        {
            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {
                //Streamreader för att konvertera bytes till tecken
                using (StreamReader reader = new StreamReader(stream))
                {
                    //få ut all text på en gång
                    string filecontent = reader.ReadToEnd();
                    //Console.WriteLine(filecontent);
                    //Console.ReadLine();
                }
            }

            //Går att skriva så här istället
            string simpleReadFileContent = File.ReadAllText("maxfritid.csv");


            //Alternativt för garbage collector med iDisposable
            Stream manuallyDisposedStream = File.Open("maxfritid.csv", FileMode.Open);
            manuallyDisposedStream.Dispose();
            //Då måste man felhantera själv, LOGIK HÄR
            //Destructor för minneshantering

            List<Product> products = new List<Product>();
            
            using (FileStream stream = File.Open("Maxfritid.csv", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] columns = line.Split(_separator);

                        try
                        {
                            Product product = CreateProduct(columns);

                                /*
                            Product product = new Product
                            {
                                Id = ConvertToInt(columns[0]),
                                ProductNumber = columns[2],
                                ProductName = columns[3],
                                ProductBrand = ConvertToNullableInt(columns[4]),
                                ProductSupplier = columns[5],
                                ProductSynonyms = ConvertToArray(columns[6])
                            };
                                */

                            products.Add(product);
                        }

                        //För att undvika behandling av ogiltig data, placera behandling av produkten efter inläsning i samma try sats
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            Console.ReadLine();
            //Sortera en lista via CompareTo klassen
            //products.Sort();

            ////Sortera en lista med egen comparer
            //products.Sort(new ProductNameComparer());

            ////Sortera via LINQ med egen comparer
            IEnumerable<Product> productsSortedByName = products.OrderBy(x => x, new ProductNameComparer());

            //Sortera via LINQ helt och hållet, ändrar på listan, returnerar nya objekt
            productsSortedByName = products.OrderBy(p => p.ProductName)
                                            .ThenBy(p => p.Id)
                                            .ThenByDescending(p => p.ProductSupplier)
                                            .ToList();

            //ToList används för att genomföra sorteringen till en variabel annars körs sorteringen varje gång man loopar innehållet

            PrintProducts(productsSortedByName);
            Console.ReadLine();
            Console.WriteLine(simpleReadFileContent);
            Console.ReadLine();
        }
        static void PrintProducts (IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id}: {product.ProductName}");
            }
        }

        static Product CreateProduct(string[] columns)
        {
            
            return new Product
            {
                Id = ConvertToInt(columns[0]),
                ProductNumber = columns[2],
                ProductName = columns[3],
                ProductBrand = ConvertToNullableInt(columns[4]),
                ProductSupplier = columns[5],
                ProductSynonyms = ConvertToArray(columns[6])
            };
        }

        //konvertera till int
        static int ConvertToInt(string input)
        {
            int.TryParse(input, out int result);
            return result;
        }

        //konvertera till nullbar int
        static int? ConvertToNullableInt(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result;
            } else
            {
                return null;
            }
        }

        static string[] ConvertToArray(string input)
        {
            if (input == null)
                return new string[0];
            return input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
