//Welcome to the BoxCalculator

{
    class Box
    {
        public double length;
        public double breadth;
        public double height;
        public double width;
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;
            double sa = 0.0;

            //Fill these in with whatever you are trying to calculate!!!
            Box1.height = 24.0;
            Box1.length = 24.0;
            Box1.breadth = 48.0;
            Box1.width = 36.0;

            Box2.height = Box1.height/12;
            Box2.length = Box1.length/12;
            Box2.breadth = Box1.breadth/12;
            Box2.width = Box1.breadth/12;

            volume = Box1.height * Box1.length * Box1.breadth;
            sa = (Box1.height * Box1.length * 2) + (Box1.height * Box1.width * 2) + (Box1.length * Box1.width * 2);
            Console.WriteLine("Volume of Box in inches: {0}", volume);
            Console.WriteLine("Surface area of Box in inches: {0}", sa);

            volume = Box2.height * Box2.length * Box2.breadth;
            sa = (Box2.height * Box2.length * 2) + (Box2.height * Box2.width * 2) + (Box2.length * Box2.width * 2);
            Console.WriteLine("Volume of Box in feet: {0}", volume);
            Console.WriteLine("Surface area of Box in inches: {0}", sa);
            Console.ReadKey();
        }
    }
}
