// event

namespace Lesson11;

delegate void MouseEvents();

class Program
{
	static event MouseEvents? _mouseEnterHandler; 
	static event MouseEvents? _mouseLeaveHandler;

	static void Main()
	{
		_mouseEnterHandler += BackgroundChange;
		_mouseEnterHandler += ToolTipActive;
		_mouseEnterHandler += SizeChange;

		_mouseLeaveHandler += BackgroundChange;
		_mouseLeaveHandler += ToolTipDeactive;
		_mouseLeaveHandler += SizeChange;

		_mouseEnterHandler();
		_mouseLeaveHandler();
	}

	static void BackgroundChange() => Console.WriteLine("Background Changed");
	static void ToolTipActive() => Console.WriteLine("Tool Tip Actived");
	static void ToolTipDeactive() => Console.WriteLine("Tool Tip Deactived");
	static void SizeChange() => Console.WriteLine("Size Changed");
	static void MouseLeave() => Console.WriteLine("Mouse Leaved");
}