using System;

namespace person

{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }

        public override string ToString()
        {
            string v = $"Name: {Name}, Surname: {Surname}, Age: {Age}, Weight: {Weight}, Height: {Height}" ;
 return v;
}

        class MainClass
        {
            public static void Main(string[] args)
            {
                Person person = new Person
                {

                    Name = "FIRA",
                    Surname = "RUSTAMLI",
                    Age = 25,
                    Weight = "51",
                    Height = "165"
                };

                string personString = person.ToString();
                Console.WriteLine(personString);
            }
        }
    }
}