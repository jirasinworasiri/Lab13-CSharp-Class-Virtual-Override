using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class AnimalSound
{
    public void PlaySound(Animal animal)
    {
        animal.MakeSound();
    }
}

// โปรแกรมหลักสำหรับทดสอบ
class Program
{
    static void Main()
    {
        AnimalSound soundPlayer = new AnimalSound();

        Animal myDog = new Dog();
        Animal myCat = new Cat();

        soundPlayer.PlaySound(myDog); // Output: Dog barks
        soundPlayer.PlaySound(myCat); // Output: Cat meows
    }
}
