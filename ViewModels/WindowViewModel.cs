using System;
using LunarByte.MVVM;

public class WindowViewModel : ViewModel, IWindowViewModel
{
	private Event<ButtonType> CloseWindowEventField = new Event<ButtonType>();


	public Event<ButtonType> CloseWindowEvent
	{
		get { return CloseWindowEventField; }
	}
}

public interface IWindowViewModel
{
	Event<ButtonType> CloseWindowEvent { get; }
}
