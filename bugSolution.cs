public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize MyProperty before using it.
        MyProperty = 10; 
        int value = MyProperty * 2; // Now value will be 20
    }
}