using System;
namespace InheritanceApplication
{
    class Bear
    {
        public void setNumP(int p)
        {
            numP = p;
        }

        public void setNumG(int g)
        {
            numG = g;
        }
        protected int numP;
        protected int numG;
    }

    // Derived class
    class Bears : Bear
    {
        public int getNum()
        {
            return (numP + numG);
        }
    }

    // Derived class
    class Types : Bear
    {
        public string getTypes()
        {
            numP = 3;
            numG = 7;
            return string.Format("Number of polar bears:" + numP + " Number of grizzly bears:" + numG);
        }
    }

    class BearCalculator
    {
        static void Main(string[] args)
        {
            Bears B = new Bears();
            Types T = new Types();

            B.setNumP(3);
            B.setNumG(7);

            // Print the area of the object.
            Console.WriteLine(T.getTypes());
            Console.WriteLine("Total number of bears:{0}", B.getNum());
            Console.ReadKey();
        }
    }
}
