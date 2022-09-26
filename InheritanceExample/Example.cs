namespace InheritanceExample
{
    public abstract class A
    {
        //Private members are visible only in derived classes that are nested in their base class. 
        private int _value = 10;

        //Protected members are visible only in derived classes.
        protected int _value2 = 20;

        //Internal members are visible only in derived classes that are located in the same assembly as the base class
        internal int _value3 = 30;

        //Public members are visible in derived classes and are part of the derived class' public interface.
        public void Method1()
        {
            // Method implementation.
        }

        public virtual void Method2()
        {
            // Method implementation.
        }

        public abstract void Method3();

        public class B : A
        {
            public int GetValue()
            {
                return _value;
            }

            public override void Method3()
            {
                throw new NotImplementedException();
            }
        }
    }

    public class C : A
    {

        //Private members are visible only in derived classes that are nested in their base class. 
        //    public int GetValue()
        //    {
        //        return _value;
        //    }

        public int GetValue2()
        {
            return _value2;
        }

        public int GetValue3()
        {
            return _value3;
        }

        //public override void Method1() // Generates CS0506.
        //{
        //    // Do something else.
        //}

        public override void Method2()
        {
            // Do something else.
        }

        public override void Method3()
        {
            throw new NotImplementedException();
        }
    }

    public class AccessExample
    {
        public static void Main(string[] args)
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());
        }
    }
}
