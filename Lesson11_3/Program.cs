namespace Lesson11_3;

class Program
{
	static void Foo1() { }
	static void Foo2(int n) { }
	static void Foo3(int n, string s) { }

	static void Main()
	{
		// Action, Func, Predicate

		Action action1 = Foo1;
		Action<int> action2 = Foo2;
		Action<int, string> action3 = Foo3;

		// Lambda expression
		Action action4 = () => { Console.Write("Nuran"); };
		action4 += () => { Console.WriteLine("Huseyn"); };
		Action<int> action5 = i => { }; // Foo2
		Action<int, string> action6 = (i, s) => { }; // Foo3

		Action<int, string> action7 = delegate (int i, string s) { }; // anonymous

		action4();


		// Func
		Func<int> func1 = () => { return 259; };
		Console.WriteLine(func1());

		// Task
		Func<string, string> f1 = s => { return "Huseyn"; };
		Func<string, string> f2 = delegate (string s) { return "Nuran"; };
		Func<string, int, int> f3 = (s, i) => { return 259; };
		Func<string, int, int> f4 = delegate (string s, int i) { return 925; };

		// Predicate
		Predicate<int> p = i => { return true; };
		Predicate<string> p_alternative = delegate (string s) { return false; };
	}
}