using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dozer = new BullDozer("yellow", "mini");
            var dozer2 = new BullDozer("red", "large");
            Console.WriteLine("Bulldoze1 is " + dozer.color);
            Console.WriteLine("Bulldoze2 is " + dozer2.color);
        }
    }

    public class BullDozer
    {
        public BullDozer(string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }

        public string color { get; set; }
        public string size { get; set; }
    }
}
