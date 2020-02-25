using System;

namespace WasteRecycling
{
    public class Dustbin
    {
        public string color;
        public PaperGarbage[] PaperContent;
        public PlasticGarbage[] PlasticContent;
        public Garbage[] HouseWasteContent;

        public Dustbin(string color)
        {
            this.color = color;
            PaperContent = new PaperGarbage[0];
            PlasticContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
        }

        public void DisplayContents()
        {
            Console.WriteLine(color + " Dustbin!");
            Console.WriteLine();
            Console.WriteLine("House waste content: {0} item(s)",HouseWasteContent.Length);
            foreach (Garbage hGarbage in HouseWasteContent)
            {
                if (hGarbage != null)
                {
                    Console.WriteLine(hGarbage.Name);
                }
            }
            Console.WriteLine();
            Console.WriteLine(@"Paper content: {0} item(s)", PaperContent.Length);
            foreach (Garbage paperGarbage in PaperContent)
            {
                if (paperGarbage != null)
                {
                    Console.WriteLine(paperGarbage.Name);
                }
            }
            Console.WriteLine();
            Console.WriteLine(@"Plastic content: {0} item(s)", PlasticContent.Length);
            foreach (Garbage plasticGarbage in PlasticContent)
            {
                if (plasticGarbage != null)
                {
                    Console.WriteLine(plasticGarbage.Name);
                }
            }
            Console.WriteLine();
        }
        public void ThrowOutGarbage(Garbage garbage)
        {
            // Throw Out Plastic Garbage
            if (garbage is PlasticGarbage)
            {
                PlasticGarbage plasticGarbage = (PlasticGarbage)garbage;
                if (plasticGarbage.Cleaned)
                {
                    int temp = PlasticContent.Length + 1;
                    PlasticContent = new PlasticGarbage[temp];
                    PlasticContent[temp - 1] = plasticGarbage;
                }
                else
                {
                    throw new DustbinContentException();
                }
            }

            // Throw Out Paper Garbage
            else if (garbage is PaperGarbage)
            {
                PaperGarbage paperGarbage = (PaperGarbage)garbage;
                if (paperGarbage.Squeezed)
                {
                    int temp = PaperContent.Length + 1;
                    PaperContent = new PaperGarbage[temp];
                    PaperContent[temp - 1] = paperGarbage;
                }
                else
                {
                    throw new DustbinContentException();
                }
            }
                
            // Throw Out Garbage
            else if (garbage is Garbage)
            {
                int temp = HouseWasteContent.Length + 1;
                HouseWasteContent = new Garbage[temp];
                HouseWasteContent[temp - 1] = garbage;
            }
        }

        public void EmptyContents()
        {
            PlasticContent = new PlasticGarbage[0];
            PaperContent = new PaperGarbage[0];
            HouseWasteContent = new Garbage[0];
        }

    }
}
