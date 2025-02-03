public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior or exceptions.
        int value = MyProperty; // Bug: Potential uninitialized property access
    }
}