using ClassLibraryIT;

namespace yagonchi
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Calc calc = new Calc();

            //int a = 6;
            //int b = 3;
            //double radius = 4.15;

            //Console.WriteLine($"Sum: {calc.Sum(a, b)}");
            //Console.WriteLine($"Sub: {calc.Sub(a, b)}");
            //Console.WriteLine($"Mul: {calc.Mul(a, b)}");
            //Console.WriteLine($"Div: {calc.Div(a, b)}");
            //Console.WriteLine($"Square: {calc.Square(radius)}");
            //Console.ReadKey();

            Gun gun = new Gun(-40,"Desert Eagle",7);
            
            Player player = new Player("Terrorist",100,0,800,"b1t",gun);

            Console.WriteLine(player.Seat());

            player.Gun.Shoot();



        }
    }

}

