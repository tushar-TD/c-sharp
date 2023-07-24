namespace delegates
{
    
    public delegate void Mydel(int a);

    class Calculation
    { 
        public static void Display(int s)
        {
            Console.WriteLine(s);
        }
        public static void Square( int s)
        { 
            Console.WriteLine(s*s);
        }

        public static void Cube(int s) 
        {
            Console.WriteLine(s*s*s);
        }
    }

    class Calc
    {
        public static void Multi(int n)
        {
            Console.WriteLine(10*n);
        }
    }


    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("here we are calling methods by delegates");
            //creating object/instance of delegates 
            //d.Invoke(5); or
          

            //Calculation c = new Calculation();
            Mydel d1=new Mydel(Calculation.Square);
            d1.Invoke(9);

            Mydel d=new Mydel(Calculation.Cube);
            d.Invoke(10);

        }
    }
}