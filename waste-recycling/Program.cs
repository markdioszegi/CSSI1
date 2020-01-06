namespace WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Garbage[] rottenTomatoes = new Garbage[3];
            for (int i = 0; i < 3; i++)
            {
                rottenTomatoes[i] = new Garbage("rotten tomato nr." + (i + 1));
            }
            PlasticGarbage milkJug = new PlasticGarbage("plastic milk jug", false);
            Dustbin dustbin = new Dustbin("Red");
            dustbin.DisplayContents();
            for (int i = 0; i < 3; i++)
            {
                /*
                    She throws every piece of rotten tomato in the dustbin.
                    This doesn't mean the tomato Garbage instance will be destroyed or anything,
                    they are just now inside of the Dustbin object.
                */
                dustbin.ThrowOutGarbage(rottenTomatoes[i]);
            }
            if (!milkJug.Cleaned)
            {
                milkJug.Clean();
            }
            dustbin.ThrowOutGarbage(milkJug);
            dustbin.EmptyContents();
            dustbin.DisplayContents();
        }
    }
}
