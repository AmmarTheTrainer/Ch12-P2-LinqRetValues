using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12_P2_LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Internet Surfing

            #region Return a Query from a Method



            #endregion

            #endregion

            Console.WriteLine("***** LINQ Return Values *****\n");

            //IEnumerable<string> subset = GetStringSubset();

            //foreach (string item in subset)
            //{
            //    Console.WriteLine(item);
            //}

            #region Returning LINQ Results via Immediate Execution

            string[] methodResult = GetStringSubsetAsArray();

            foreach (string item in methodResult)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadLine();
        }

        static string[] GetStringSubsetAsArray()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

            //IEnumerable<string> theRedColors = (from c in colors where c.Contains("Red") select c).ToArray();
             string[] theRedColors = (from c in colors where c.Contains("Red") select c).ToArray();
            
            // Map results into an array.
            //return theRedColors.ToArray();
            return theRedColors;
        }
        
        private static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };
            // Note subset is an IEnumerable<string>-compatible object.
            IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
            return theRedColors;
        }
    }
}
