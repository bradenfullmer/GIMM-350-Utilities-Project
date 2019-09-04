using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.write lines print to console
            Console.WriteLine("Hello, world!");

            //these vars are setting variables to be used later on
            var meaningOfLife = 42;
            var smallPi = 3.14f;
            var bigPi = 3.14159265359;
            var vaporWare = "Half Life 3";
            const bool likesPizza = true;

            string[] writers = { "Anthony", "Brian", "Eric", "Sean" };
            string[] editors = new string[5];
            Console.WriteLine(writers[2]);

            //these are checking to see if certain conditions are met before they execute the code within
            writers[0] = "Ray";
            //I got rid of useless code due to this being a boolean. They had it as a == flase when it works just as well to put an ! at the beginning.
            if (!likesPizza)
            {
                Console.WriteLine("You monster!");
            }

            //this was actually interesting to look into. turns out that this is a single line if else statement. This is pretty neat to know for future refrence.
            bool isMonster = (likesPizza == true) ? false : true;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C# Rocks!");
            }
            for (int i = 0; i < writers.Length; i++)
            {
                string writer = writers[i];
                Console.WriteLine(writer);
            }
            foreach (string writer in writers)
            {
                Console.WriteLine(writer);
            }
            if (meaningOfLife == 42)
            {
                bool inScope = true;
            }

            //creating a 2d object/shape and then attaching things to it.
            Point2D myPoint = new Point2D();
            myPoint.X = 10;
            myPoint.Y = 20;

            Point2D anotherPoint = new Point2D();
            anotherPoint.X = 5;
            anotherPoint.Y = 15;

            myPoint.AddPoint(anotherPoint);
            Console.WriteLine(myPoint.X);
            Console.WriteLine(myPoint.Y);

            Point2D yetAnotherPoint = myPoint;
            yetAnotherPoint.X = 100;
            Console.WriteLine(myPoint.X);
            Console.WriteLine(yetAnotherPoint.X);

            Point2DRef pointRef = new Point2DRef();
            pointRef.X = 20;
            Point2DRef anotherRef = pointRef;
            anotherRef.X = 25;

            Console.WriteLine(pointRef.X);
            Console.WriteLine(anotherRef.X);

            pointRef = null;
            anotherRef.X = 125;
            Console.WriteLine(anotherRef.X);
            anotherRef = null;

            RenFairePerson person = new RenFairePerson();
            person.Name = "Igor the Ratcatcher";
            person.SayHello();
        }
    }
    //building the 2d structure from the code.
    struct Point2D
    {
        public int X;
        public int Y;
        public void AddPoint(Point2D anotherPoint)
        {
            this.X = this.X + anotherPoint.X;
            this.Y = this.Y + anotherPoint.Y;
        }
    }

    class Point2DRef
    {
        public int X;
        public int Y;

        public void AddPoint(Point2DRef anotherPoint)
        {
            this.X = this.X + anotherPoint.X;
            this.Y = this.Y + anotherPoint.Y;
        }
    }

    class Person
    {
        public string Name;
        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class RenFairePerson : Person
    {
        public override void SayHello()
        {
            base.SayHello();
            Console.Write("Huzzah!");
        }
    }


}