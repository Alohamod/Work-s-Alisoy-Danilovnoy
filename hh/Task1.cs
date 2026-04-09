using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Task1 : Purple
    {
        private int _output;
        public int Output => _output;
        public Task1(string text) : base(text) 
        {
            _output = default(int);
            //Review();
        }

        public override void Review()
        {
            _output = GetWords(Input).Length;
        }
        public override string ToString()
        {
            return $"{Input}{Environment.NewLine}{_output}";
        }
    }
}
