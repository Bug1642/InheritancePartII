namespace Exercise
{
    public class Animal
    {
        string name;
        string birthMetod;

        public Animal(string name, string birthMetod) 
        {
            this.name = name;
            this.birthMetod = birthMetod;
        }
        public string GiveBirth()
        {
            return this.birthMetod;
        }
    }

    public class Bird : Animal
    {
        bool flies;

        public Bird() : base("Unknown", "eggs")
        {
            this.flies = true;
        }

        public Bird(string name, bool flies)
            : base(name, "eggs")
        {
            this.flies = flies;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird("Parrot", true);
            Console.WriteLine(bird.GiveBirth());
        }
    }
}