namespace alap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            szamokbeker();
        }
        static void szamokbeker()
        {
            int szam = 0;
            Console.WriteLine("Kérlek adj meg egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{szam}");
            if (szam / 3 == 0 || szam/4 ==0 || szam/9 == 0)
            {
                Console.WriteLine("A szám osztható 3-mal, 4-gyel és 9-cel");
            }
            else if (szam /3 == 0|| szam/4== 0)
            {
                Console.WriteLine("A szám osztható 3-mal és 4-gyel");
            }
            else if (szam /3==0|| szam/9== 0)
            {
                Console.WriteLine("A szám osztható 3-mal és 9-cel")
            }
        }
    }
}
