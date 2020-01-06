namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; set; }
        public PlasticGarbage(string name, bool cleaned) : base(name)
        {
            Cleaned = cleaned;
        }
        public void Clean()
        {
            Cleaned = true;
        }
    }
}
