using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class Purple
    {
        protected static char[] _prep;
        private string _input;
        public string Input => _input;

        static Purple()
        {
            _prep = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
        }
        protected Purple(string input)
        {
            _input = input;

        }
        public abstract void Review();


        public virtual void ChangeText(string text)
        {
            _input = text;
            Review();
        }

        protected string[] GetWords(string input)
        {
            string[] word_drirty =  input.Split(' ');
            return word_drirty;

        }


    }
}
