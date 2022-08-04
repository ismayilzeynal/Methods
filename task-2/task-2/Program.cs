using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius: ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side-1: ");
            double Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side-2: ");
            double Side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side-3: ");
            double Side3 = Convert.ToDouble(Console.ReadLine());

            #region overload-1
            Console.WriteLine(Area(Radius));    // circle
            #endregion

            #region overload-2
            Console.WriteLine(Area(Side1, Side2));  // rectangle
            #endregion

            #region overload-3
            Console.WriteLine(Area(Side1, Side2, Side3));   // paralelepiped
            #endregion

            #region overload-4
            if(Side1+Side2>Side3 && Side1+Side3>Side2 && Side2+Side3>Side1)
                Console.WriteLine(Area(Side1, Side2, Side3, Radius));   // triangle inside circle
            else
                Console.WriteLine("can't be triangle");
            #endregion


        }
        #region overload-1
        static double Area(double r)    // circle
        {
            return 3 * r * r;
        }
        #endregion

        #region overload-2
        static double Area(double Side1, double Side2)  // rectangle
        {
            return Side1*Side2;
        }
        #endregion

        #region overload-3
        static double Area(double Side1, double Side2, double Side3)    //paralelepiped
        {
            return 2*(Side1 * Side2 + Side1 * Side3 + Side2 * Side3);
        }
        #endregion

        #region overload-4
        static double Area(double Side1, double Side2, double Side3, double r)  // triangle inside circle
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return p * r;
        }
        #endregion

    }
}
