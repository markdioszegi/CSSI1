namespace WasteRecycling
{
    public class Dustbin
    {
        string Color { get; set; }
        public PaperGarbage[] PaperContent;
        public PlasticGarbage[] PlasticContent;
        public Garbage[] HouseWasteContent;

        public Dustbin(string color)
        {
            Color = color;
            PaperContent = new PaperGarbage[0];
            PlasticContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
        }

        public void DisplayContents()
        {
            //Garbage
            int len = HouseWasteContent.Length;
            System.Console.WriteLine($"{Color} Dustbin!\n");
            if (len > 1)
            {
                System.Console.WriteLine($"House waste content: {len} items");
            }
            else
            {
                System.Console.WriteLine($"House waste content: {len} item");
            }
            foreach (Garbage garbage in HouseWasteContent)
            {
                System.Console.WriteLine($"\t{garbage.Name}");
            }
            //Paper
            len = PaperContent.Length;
            if (len > 1)
            {
                System.Console.WriteLine($"Paper content: {len} items");
            }
            else
            {
                System.Console.WriteLine($"Paper content: {len} item");
            }
            foreach (PaperGarbage garbage in PaperContent)
            {
                System.Console.WriteLine($"\t{garbage.Name}");
            }
            //Plastic
            len = PlasticContent.Length;
            if (len > 1)
            {
                System.Console.WriteLine($"Plastic Content: {len} items");
            }
            else
            {
                System.Console.WriteLine($"Plastic Content: {len} item");
            }
            foreach (PlasticGarbage garbage in PlasticContent)
            {
                System.Console.WriteLine($"\t{garbage.Name}");
            }
        }

        public void ThrowOutGarbage(Garbage garbage)
        {
            if (garbage is PlasticGarbage)
            {
                PlasticGarbage plasticGarbage = (PlasticGarbage)garbage;
                if (plasticGarbage.Cleaned)
                {
                    int newLength = PlasticContent.Length + 1;
                    PlasticContent = new PlasticGarbage[newLength];
                    PlasticContent[newLength - 1] = plasticGarbage;
                }
                else
                {
                    throw new DustbinContentException();
                }
            }
            else
            {
                if (garbage is PaperGarbage)
                {
                    PaperGarbage paperGarbage = (PaperGarbage)garbage;
                    if (paperGarbage.Squeezed)
                    {
                        int newLength = PaperContent.Length + 1;
                        PaperContent = new PaperGarbage[newLength];
                        PaperContent[newLength - 1] = paperGarbage;
                    }
                    else
                    {
                        throw new DustbinContentException();
                    }
                }
                else
                {
                    if (garbage is Garbage)
                    {
                        int newLength = HouseWasteContent.Length + 1;
                        HouseWasteContent = new Garbage[newLength];
                        HouseWasteContent[newLength - 1] = garbage;
                    }
                    else
                    {
                        throw new DustbinContentException();
                    }
                }
            }
        }
        public void EmptyContents()
        {
            PaperContent = new PaperGarbage[0];
            PlasticContent = new PlasticGarbage[0];
            HouseWasteContent = new Garbage[0];
        }
    }
}
