using System;
using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using UnityEngine;
using Zenject;

public abstract class GameWindowView<TViewModel> : View<TViewModel>, IGameWindowView
	where TViewModel : IWindowViewModel
{
	private GameWindowType GameWindowTypeField;

	public GameWindowType GameWindowType
	{
		get { return GameWindowTypeField; }
	}

	public IWindowViewModel WindowViewModel
	{
		get { return ViewModel; }
	}
}


public interface IGameWindowView
{
	GameWindowType GameWindowType { get; }
	IWindowViewModel WindowViewModel { get; }
}

