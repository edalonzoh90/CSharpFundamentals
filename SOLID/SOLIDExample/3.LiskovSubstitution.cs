namespace SOLIDExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Orange();
            Debug.WriteLine(apple.GetColor());
        }
    }
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

    //Most implementations of LSP involve polymorphism to create class-specific behavior for the same calls. 
    class ProgramSLP
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Orange();
            Debug.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Debug.WriteLine(fruit.GetColor());
        }
    }
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
