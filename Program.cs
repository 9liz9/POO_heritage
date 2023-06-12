namespace S04_POO_heritage;

abstract class Animal
{
    public abstract void Move();
    

    public void Eat()
    {
        Console.WriteLine("L'animal mange.");
    }
}

abstract class Biped : Animal
{
    public override void Move(){
        Console.WriteLine("L'animal bipède se deplace sur ses deux jambes ou pattes.");
    }
    
}

abstract class Quadruped : Animal
{
    public override void Move(){
        Console.WriteLine("L'animal quadrupède se déplace à quattre pattes.");
    }
    
}

class Human : Biped
{
    public override void Move()
    {
        Console.WriteLine("L'humain marche sur deux jambes.");
    }
}

class Monkey : Biped
{
    public override void Move()
    {
        Console.WriteLine("Le singe marche sur ses deux pattes.");
    }
}

class Elephant : Quadruped
{
    public override void Move()
    {
        Console.WriteLine("L'éléphant marche sur ses quatre pattes.");
    }
}

class Tortoise : Quadruped
{
    public override void Move()
    {
        Console.WriteLine("La tortue marche sur ses quatre pattes.");
    }
}

class Lizard : Quadruped
{
    public override void Move()
    {
        Console.WriteLine("Le lezard marche sur ses quatre pattes.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[]
        {
            new Human(),
            new Monkey(),
            new Elephant(),
            new Tortoise(),
            new Lizard()
        };

        foreach (Animal animal in animals)
        {
            animal.Move();
            animal.Eat();
            Console.WriteLine();
        } 
    }
}