using System;
namespace WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Garbage[] rottenTomatoes = new Garbage[3];
            for (int i = 0; i < rottenTomatoes.Length; i++)
            {
                rottenTomatoes[i] = new Garbage("rotten tomato nr." + (i + 1));
            }

            PlasticGarbage milkJug = new PlasticGarbage("plastic milk jug", true);

            PaperGarbage nemzetiSport = new PaperGarbage("Nemzeti Sport", true);

            Dustbin dustbin = new Dustbin("Jenny's handsome");

            
            Console.WriteLine("1. ROUND:");
            dustbin.DisplayContents();
            dustbin.ThrowOutGarbage(milkJug);
            dustbin.ThrowOutGarbage(nemzetiSport);
            for (int i = 0; i < rottenTomatoes.Length; i++)
            {

                dustbin.ThrowOutGarbage(rottenTomatoes[i]);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("2. ROUND:");
            dustbin.DisplayContents();
            dustbin.EmptyContents();
            Console.WriteLine("---------------------------");
            Console.WriteLine("3. ROUND:");
            dustbin.DisplayContents();






        }
    }
}
