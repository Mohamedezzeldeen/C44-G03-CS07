namespace C44_G03_CS07
{
    #region Q01
    //public struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //}
    #endregion

    #region Q02

    //public struct Point
    //{
    //    public int X { get; set; }

    //    public int Y { get; set; }

    //    public Point( int _X , int _Y )
    //    {
    //        X = _X; 
    //        Y = _Y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Point ({X} , {Y})";
    //    }

    //}

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people =
            //{
            //    new Person { Name = "Ahmed", Age = 25 },
            //    new Person { Name = "Sara", Age = 30 },
            //    new Person { Name = "Mona", Age = 22 }
            //};

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Person {i + 1}: Name = {people[i].Name}, Age = {people[i].Age}");
            //}
            #endregion

            #region Q2.Create a struct called "Point" to represent a 2D point with properties "X" and   "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point[] p = new Point[2];
            //int x;
            //int y;
            //bool Flag_X;
            //bool Flag_Y;
            //for (int i = 0; i < p.Length; i++)
            //{
            //    Console.WriteLine($"Point Number {i+1}");

            //    do
            //    {
            //        Console.Write("Enter X : ");
            //        Flag_X = int.TryParse(Console.ReadLine(), out x);
            //    }
            //    while (!Flag_X);


            //    do
            //    {
            //        Console.Write("Enter Y : ");
            //        Flag_Y = int.TryParse(Console.ReadLine(), out y);
            //    }
            //    while (!Flag_Y);

            //    p[i] = new Point(x, y);


            //}

            //double distance = Math.Sqrt(Math.Pow(p[0].X - p[1].X,2) + Math.Pow(p[0].Y - p[1].Y, 2));

            //Console.WriteLine($"First Point : {p[0]}");
            //Console.WriteLine($"Second Point : {p[1]}");
            //Console.WriteLine($"The Distance Is {distance}");
            #endregion
        }
    }
}
