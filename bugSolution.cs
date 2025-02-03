public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize the property in the constructor
        MyProperty = 0; 
    }

    public void MyMethod()
    {
        // Accessing the property after initialization
        int value = MyProperty; 
    }
}