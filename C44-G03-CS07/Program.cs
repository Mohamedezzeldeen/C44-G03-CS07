namespace C44_G03_CS07
{
    #region V01


    internal class User
    {
        public int Id { get; set; }

        //public bool[] Permisions { get; set; } = new bool[4];

        public Permisions Permisions { get; set; }
    }

    [Flags]
    internal enum Permisions : byte
    {
        Write = 1,
        Read = 2,
        Execute = 4,
        Delete = 8,
    }


    #endregion

    #region V02

    //internal struct Point
    //{
    //    #region Attributes

    //    public int X;

    //    public int Y;

    //    #endregion

    //    #region Constructors
    //    // It Is Special Function
    //    // 1. Becouse Name As Struct Name
    //    // 2. Has No Return Type

    //    // He Build This Function By him Self
    //    public Point()
    //    {
    //        X = default;
    //        Y = default;
    //    }

    //    public Point(int _x, int _y)
    //    {
    //        X = _x;
    //        Y = _y;
    //    }

    //    public Point(int Number)
    //    {
    //        X = Y = Number;
    //    }
    //    #endregion

    //}

    #endregion

    #region V03

    internal struct Point
    {
        #region Attributes

        public int X;

        public int Y;

        #endregion

        #region Constructors
        // It Is Special Function
        // 1. Becouse Name As Struct Name
        // 2. Has No Return Type

        // He Build This Function By him Self
        public Point()
        {
            X = default;
            Y = default;
        }

        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public Point(int Number)
        {
            X = Y = Number;
        }
        #endregion



        #region Methods

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        #endregion


    }



    #endregion

    #region V05

    #region Encapsulation

    internal struct Employee
    {
        #region Attributes
        //public int Id;
        //public string Name;

        private int Id;
        private string Name;
        #endregion

        #region Encapsulation

        #region Getter And Setter

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Value)
        {
            Name = Value;
        }

        #endregion

        #region Property
        //مميزاتها
        // 1. بقدر اغير الاسم هنا من غير ما العالم الخارجي يتاثر بالتغيير
        // 2. بقدر اخلي الجيت لوحده او الست لوحده مش محتاج يبقوا الاتنين متفعلين عادي
        // 3. بقدر احط شرط عادي 
        // مثال
        // set { Empsalary = value > 5000 ? 5000 : value ; }
        private decimal Empsalary;

        public decimal Salary // FullProperty
        {
            get { return Empsalary; }
            set { Empsalary = value; }
        }

        public int Age { get; set; } // Automatic Property و دا مش محتاج تعمل انت اتربيوت عشان هو بيعملها اوتو 


        //private decimal Deduction;
        public decimal EmpDeduction // Read Only Property  
        {
            //get { return Deduction; }
            //set { Deduction = value; }

            get { return Salary * 0.1M; } // حطينا ام عشان هنا الارقام ديسيمال و الارقام في الطبيعي دبل
        }
        #endregion

        #endregion

        #region Constructors
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Employee(int id, string name, decimal empsalary)
        {
            Id = id;
            Name = name;
            Salary = empsalary;
        }

        #endregion

        #region Method
        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name}";
        }
        #endregion




    }

    #endregion

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V01

            #region Enum

            //User user01 = new User();
            //user01.Id = 10;
            //user01.Permisions[0] = true; // Write
            //user01.Permisions[1] = false; // Read 
            //user01.Permisions[2] = false; // Execute
            //user01.Permisions[3] = false; // Delete

            //user01.Permisions = Permisions.Read;
            //Console.WriteLine(user01.Permisions);

            //user01.Permisions = (Permisions)3;
            //Console.WriteLine(user01.Permisions);

            //user01.Permisions = (Permisions)10;
            //Console.WriteLine(user01.Permisions);

            //------------------------------------------------------\\

            //user01.Permisions = Permisions.Read ^ Permisions.Execute;
            ////or
            //user01.Permisions ^= Permisions.Delete;
            //Console.WriteLine(user01.Permisions);

            //user01.Permisions = Permisions.Read & Permisions.Execute;
            ////or
            //user01.Permisions &= Permisions.Delete;
            //Console.WriteLine(user01.Permisions);

            //user01.Permisions = Permisions.Read | Permisions.Execute;
            ////or
            //user01.Permisions |= Permisions.Delete;
            //Console.WriteLine(user01.Permisions);
            #endregion

            #endregion

            #region V02

            #region Struct

            #region Example 01
            //Point P01; // كدا خزنت 8 ابيت في الستاك

            //P01 = new Point(10); // في الكلاس New  في الاستراكت غير ال New  معلومة ال
            //// New Is Just For Constructor Selection That Will Used To Inialize P01 Attribute

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y); 
            #endregion

            #endregion

            #endregion

            #region V03

            #region Struct

            #region Example 02

            //Point P01 = new Point(10,20);
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Point P02 = new Point(30, 40);
            //Console.WriteLine(P02.X);
            //Console.WriteLine(P02.Y);

            //P02 = P01;
            //Console.WriteLine(P02.X);
            //Console.WriteLine(P02.Y);

            //P01.X = 500;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);

            //int X = 10;
            //Console.WriteLine(X);
            //Console.WriteLine(P01); //Demo.Point
            //Console.WriteLine(P01.ToString()); //Demo.Point

            #endregion

            #endregion

            #endregion

            #region V05

            #region Encapsulation

            //Employee emp = new Employee(10,"Ahmed");

            ////emp.Id = 20; // Set Id Direct By Att
            ////Console.WriteLine(emp.Id); // Get Id Direct By Att

            ////emp.SetName("Mohamed");
            ////Console.WriteLine(emp.GetName());

            //emp.Salary = 5000;
            //Console.WriteLine(emp.Salary);

            ////emp.Age = 10;
            ////Console.WriteLine(emp.Age);
            //Console.WriteLine(emp.EmpDeduction);
            #endregion

            #endregion
        }
    }
}
