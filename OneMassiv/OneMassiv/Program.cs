using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMassiv
{
    public class Massiv
    {
        const int n = 5;
        double[] mas = new double[n];
        Random r = new Random();
        Random k = new Random();
        bool flag = false;
        public double[] InMas()
        {
            for (int i = 0; i < n; i++)
            {
                mas[i] = k.Next(-10, 10) * r.NextDouble();

            }
            return mas;
        }
        
        public double SumOtr()
        {
            double x = 0;
            InMas();
            Array.Sort(mas);
            foreach (double s in mas)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i < n; i++)
            {
                if (mas[i] < 0)
                {
                    x += mas[i];
                }
            }
            flag = true;
            return x;
        }
        public double UmValue()
        {
            double w = 1;
            if (!flag) InMas();
            Array.Sort(mas);
            foreach (double s in mas)
            {
                Console.WriteLine(s);
            }
            for (int i = 1; i < n-1; i++)
            {
                w *= mas[i];
            }
            return w;
        }
    }
    class Program
    {


        static void Main(string[] args)
        {

            Massiv c = new Massiv();

            double d = c.SumOtr();
            Console.WriteLine("Сумма отрицательных элементов: {0}", d);
            double p = c.UmValue();
            Console.WriteLine("Произведение элементов от минимального до максимального: {0}", p);
            Console.ReadKey();
        }
     }
    
}
