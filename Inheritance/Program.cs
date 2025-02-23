using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird hawk = new Bird()
            {
                Name = "Goshawks",
                Age = 4,
                BeakType = "Curved",
                CanFly = true,
                WingSpan = 3,
                Weight = 7.8,
                Species = "Hawk",
                FeatherColor = "Gray and White",
            };
            Console.WriteLine($"{hawk.Name} are {hawk.Age} years old, has a {hawk.BeakType} beak type and are a {hawk.FeatherColor}. Their wing span is {hawk.WingSpan} feet and they can weigh {hawk.Weight}oz. With that wing span it is {hawk.CanFly} they can fly. As you can probably tell it is in the {hawk.Species} family.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile lizard = new Reptile()
            {
                Name = "Gecko",
                Age = 2,
                Weight = 0.5,
                Species = "Lizard",
                ScaleColor = "Green",
                HasLegs = true,
                IsColdBlooded = true,
                Habitat = "Rainforest",
            };
            Console.WriteLine($"{lizard.Name}s are {lizard.Age} years old, with {lizard.ScaleColor} scales. They weigh around {lizard.Weight}oz. They have legs: {lizard.HasLegs}, they are cold-blooded: {lizard.IsColdBlooded}. They live in the {lizard.Habitat}, and belong to the {lizard.Species} family.");
        }
    }
}
