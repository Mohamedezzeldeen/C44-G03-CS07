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

        }
    }
}
