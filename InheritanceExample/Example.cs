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

        //Virtual is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class
        //When a virtual method is invoked, the run-time type of the object is checked for an overriding member. The overriding member in the most derived class is called, which might be the original member, if no derived class has overridden the member.
        public virtual void Method2()
        {
            // Method implementation.
        }

        public abstract void Method3();

        public virtual void Method4()
        {
            Console.WriteLine("Method 4 - Base");
        }

        public void Method5()
        {
            //Anonymous types are defined by their named data members.
            var v = new { Amount = 108, Message = "Hello" };
        }

        public void Method6()
        {
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            //Extended Method
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }
        }

        //Nested class
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


        // when your application encapsulates unmanaged resources, such as windows, files, and network connections,
        // you should use finalizers to free those resources.
        // When the object is eligible for finalization, the garbage collector runs the Finalize method of the object.
        ~A()  // finalizer
        {
            Console.WriteLine("Finalizer is executing.");
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
            var c = new C();
            c.Method4();
            Console.ReadLine();
        }
    }
}
