using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terraristi Petya = new igil(29, "калаш");
            Terraristi Vanya = new Talib(67, "гранатомет");
            Talib gosha = new Talib(13, "гранатомет");
            igil Roma = new igil(100, "гранaтомет");
            Roma.Print();
            Console.WriteLine(Roma.Guns("гранатомет"));
            gosha.Print();
            Console.WriteLine(gosha.Guns("гранатомет"));
            Petya.Print();
            Console.WriteLine(Petya.Guns("Ak-47"));
            Vanya.Print();
            Console.WriteLine(Vanya.Guns("гранатомет"));

        }
    }
    public abstract class Terraristi
    {

        private int _id;
        private string _gun;

        public abstract string Type { get; }
        public Terraristi(int id, string gun)
        {
            _id = id;
            _gun = gun;
        }
        public abstract void Voic();

        public virtual  string Guns( string gun)
        {
            if (gun == null) return null;
            {
                if (gun != "гранатомет") return "хорошая пушка";
                return "баклажан ну ты совсем дурак";
            }
        }
        public virtual void Print()
        {
            Console.WriteLine("оружку покажи " + _gun);
            Console.WriteLine("Terrarist ID " + _id);

        }
    }
    public class Talib: Terraristi
    {
        public override string Type => "бородатый";
        public Talib(int id , string gun) : base(id , gun) { }
        public override void Voic() { Console.WriteLine("أمك عاهرة"); }
        public override string Guns(string gun)
        {
            return base.Guns(gun);
        }

    }
    public class igil : Terraristi
    {
        public override string Type => "с калашом";
        public igil(int id, string gun) : base(id, gun) { }
        public override void Voic() { Console.WriteLine("مورجنسترن"); }
        public new string Guns(string gun)
        {
            return "Альхамдулилях";
        }
    }

}
