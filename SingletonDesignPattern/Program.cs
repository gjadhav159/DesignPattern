using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate.Instance.Valueone = 2.4;
            Calculate.Instance.Valuetwo = 10.6;
            Console.WriteLine("Addition : " +  Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.WriteLine("\n----------------------\n");
            Calculate.Instance.Valuetwo = 11.6;
            Console.WriteLine("Addition : " + Calculate.Instance.Addition());
            Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division : " + Calculate.Instance.Division());
            Console.ReadLine();
        }
    }

    public sealed class Calculate
    {
        private Calculate()
        { }
        private static Calculate instance = null;
        public static Calculate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculate();
                }
                return instance;
            }
        }
        public double Valueone { get; set; }
        public double Valuetwo { get; set; }

        public double Addition()
        {
            return Valueone + Valuetwo;
        }
        public double Subtraction()
        {
            return Valueone - Valuetwo;
        }

        public double Multiplication()
        {
            return Valueone * Valuetwo;
        }

        public double Division()
        {
            return Valueone / Valuetwo;
        }


    }
}
