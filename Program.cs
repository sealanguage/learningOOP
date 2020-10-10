//  polymorphism
﻿//  inheritance

using System:

    namespace Bulldozer
{
        class MainClass
    {


        public static void Main(string[] args)
        {

            var man = new Man();
            var cart = new Cart();
            var alien = new Alien();
            // this was the bulldozer code
            //var dozer = new BullDozer("yellow", "mini");
            //var dozer2 = new BullDozer("red", "large");
            //Console.WriteLine("Bulldoze1 is " + dozer.color);
            //Console.WriteLine("Bulldoze2 is " + dozer2.color);
        }



        // this was the bulldozer code
        //public class BullDozer
        //{
        //public BullDozer(string _color, string _size)
        //{
        //    this.color = _color;
        //    this.size = _size;
        //}
        public class GeneralObject
        {

            public GeneralObject()
            {

            }
            public bool moves { get; set; }
            public string color { get; set; }
        }

        public class Human : GeneralObject
        {
            public Human()
            {

            }
            public string name { get; set; }
        }


        public class Man : Human
        {
            public Man()
            {

            }
        }

        public class Woman : Human
        {
            public Woman()
            {

            }
        }

        public class Cart : GeneralObject
        {
            public Cart()
            {

            }
            public string manufacturer { get; set; }
        }

        public class Alien : GeneralObject
        {
            public Alien()
            {

            }
            public string planet { get; set; }
        }

    }
}