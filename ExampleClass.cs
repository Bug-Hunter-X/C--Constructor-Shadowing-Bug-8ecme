public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        // Incorrect assignment, should be this.MyProperty = value;
        MyProperty = value; 
    }
}