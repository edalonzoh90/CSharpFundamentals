using InheritanceExample;

namespace InheritanceExample2
{
    public class D : A
    {
        //public int GetValue()
        //{
        //    return _value;
        //}

        public int GetValue2()
        {
            return _value2;
        }

        public override void Method3()
        {
            throw new NotImplementedException();
        }

        //public int GetValue3()
        //{
        //    return _value3;
        //}
    }
}
