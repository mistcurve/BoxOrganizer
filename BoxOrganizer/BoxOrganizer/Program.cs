using System;
using System.IO;
namespace BoxOrganizer
{
    class Program
    {
        public static string MENU = "1. Add a Box\n2. Search Boxes\n3. Browse Boxes\n4. Quit\n\n";

        static void Main(string[] args)
        {

            //System.IO.StreamWriter file = new System.IO.StreamWriter(@"AllBoxes.txt");
            File.ReadAllLines();
            int response;
            do
            {
                Console.WriteLine(MENU);
                response = int.Parse(Console.ReadLine());
                switch(response)
                {
                    case 1:
                        addBox();
                        break;
                    case 2:
                        searchBoxes();
                        break;
                    case 3:
                        browseBoxes();
                        break;
                    case 4:
                        response = -1;
                        break;
                    default:
                        break;
                }
            } while (response != -1);
        }

        static void addBox()
        {
            Console.WriteLine("What is in this box? seperate with spaces.");
        }
        static void searchBoxes()
        {

        }
        static void browseBoxes()
        {

        }
    }
}
