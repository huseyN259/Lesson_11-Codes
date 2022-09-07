namespace Lesson11_2;

delegate void MyDelegate();

class Program
{
	static void Foo()
	{
		Console.WriteLine("Foo");

		throw new NullReferenceException();
	}

	static void DoSomething()
	{
		Console.WriteLine("DoSomething");

		throw new ArgumentException();
	}

	static void ExceptionHandler(MyDelegate myDel)
	{
		try
		{
			myDel.Invoke();
		}
		catch (Exception)
		{
			
		}
	}

	static void Main()
	{
		MyDelegate myDelegate = Foo;
		myDelegate += DoSomething;

		ExceptionHandler(Foo);
		Console.WriteLine("some");
		ExceptionHandler(DoSomething);

		//try
		//{
		//	Foo();
		//}
		//catch (Exception)
		//{

		//}

		//try
		//{
		//	DoSomething();
		//}
		//catch (Exception)
		//{

		//}
	}
}