using System;

namespace AbscractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.AnimalSound(); // output "Dog says bark bark"
            dog.sleep(); // output "Animal is sleeping"
        }
    }


    abstract class Animal
    {

        //abstract method
        public abstract void AnimalSound();

        public void sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }


    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog says bark bark");
        }
    }
}
