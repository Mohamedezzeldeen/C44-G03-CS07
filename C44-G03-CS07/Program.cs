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

    #region Q03
    //public struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string _Name, int _Age)
    //    {
    //        _Name = Name;
    //        _Age = Age;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Name = {Name} , Age = {Age}";
    //    }
    //}
    #endregion

    #region Q04
    //public struct Rectangle
    //{  private double W;
    //   private double H;

    //    public Rectangle( double _W , double _H)
    //    {
    //        Width = _W;
    //        Height = _H;
    //    }

    //    public double Width 
    //    {
    //        get { return W; } 
    //        set
    //        {
    //            if (value > 0)
    //            {
    //                W = value;
    //            }
    //            else 
    //            {
    //                Console.WriteLine("Error");
    //            }
    //        }
    //    }


    //    public double Height
    //    {
    //        get { return H; }
    //        set
    //        {
    //            if (value > 0)
    //            {
    //                H = value;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Error");
    //            }
    //        }
    //    }

    //    public double Area
    //    {
    //        get { return W * H; }
    //    }

    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Width: {Width}, Height: {Height}, Area: {Area}");
    //    }


    //    public override string ToString()
    //    {
    //        return $"(Width : {Width} , Height : {Height})";
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

            #region Q3.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] persons = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    string name;
            //    do
            //    {
            //        Console.Write($"Please Enter The Name Of Person number {i + 1} : ");
            //        name = Console.ReadLine();
            //    } while (string.IsNullOrWhiteSpace(name));
            //    persons[i].Name = name;
            //    int age;
            //    bool flage;
            //    do
            //    {
            //        Console.Write($"Please Enter The Age Of Person number {i + 1} : ");
            //        flage = int.TryParse(Console.ReadLine(), out age);
            //    } while (!flage);
            //    persons[i].Age = age;
            //}

            //Person theBiggestPerson = persons[0];
            //for (int i = 0; i < 3; i++)
            //{
            //    if (theBiggestPerson.Age < persons[i].Age)
            //        theBiggestPerson = persons[i];
            //}
            //Console.Clear();
            //Console.WriteLine(theBiggestPerson);
            #endregion

            #region Q4.Create a struct named Rectangle that represents a rectangle with the following fields: width (type: double) , height (type: double)

            //Console.Write("Enter Width: ");
            //double w = double.Parse(Console.ReadLine());

            //Console.Write("Enter Height: ");
            //double h = double.Parse(Console.ReadLine());

            //Rectangle rect = new Rectangle(w, h);
            //rect.DisplayInfo();

            #endregion
        }
    }
}
