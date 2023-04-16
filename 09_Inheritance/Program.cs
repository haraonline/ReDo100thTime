namespace _09_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new CatVirtualProperty();
            var dog = new DogVirtualProperty();
            Console.WriteLine(cat.Sound);
            Console.WriteLine(dog.Sound);

            //is a or has a relationship (a - for class, has a - for properties)
            //Cat is an Animal
            //Dog is an Animal
            //Animal has a Sound
            //Cat has a Sound
            //Dog has a Sound
            //Cat is a Mammal
            //Dog is a Mammal
            //Mammal has a Sound
            //Cat has a Sound

        }
    }
}