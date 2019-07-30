using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using LunarByte.MVVM.Configurations;
using UnityEngine;
/// <summary>
/// Used for binding the dependencies of the Game Window View
/// </summary>
[CreateAssetMenu(fileName = nameof(GameWindowViewConfiguration), menuName = "Window/Configurations/" + nameof(GameWindowViewConfiguration))]
public class GameWindowViewConfiguration : ViewConfiguration<IWindowViewModel, WindowViewModel, WindowView>
{
	protected override void Configure(WindowViewModel viewModel, WindowView view)
	{
		
	}
}
