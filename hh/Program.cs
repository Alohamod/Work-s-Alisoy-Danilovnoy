using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Example
    {
        private int _number;
        private string _word;
        public Example(int number = -1, string word= "unknown", char color = '0') 
        {
            _number = number;
            _word = word;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Example A = new Example(13, "nerd");
            Example B = new Example(13);
            Example C = new Example('1');
            Task1 gera = new Task1("koko");
            Console.WriteLine(gera.Output);
            gera.Review();
            Console.WriteLine(gera.Output);
            Console.WriteLine(gera);
        }
    }
}
