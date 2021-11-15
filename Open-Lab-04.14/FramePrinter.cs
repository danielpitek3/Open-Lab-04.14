using System;
using System.Linq;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            string longest_String = strings.OrderByDescending(s => s.Length).First();
            int frame_length = longest_String.Length + 4; 

            string borders = "";
            borders = borders.PadRight(frame_length, '');
            Console.WriteLine(borders);

            foreach (var str in strings)
            {
                string new_String = " " + str;
                new_String = new_String.PadRight(frame_length - 1, ' ');
                new_String += "*";
                Console.WriteLine(new_String);
            }

            Console.WriteLine(borders);
        }
    }
}