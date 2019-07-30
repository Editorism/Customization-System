using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM.Configurations;
using UnityEngine;

/// <summary>
/// Used for binding the dependencies of the Customization Window View
/// </summary>
[CreateAssetMenu(fileName = nameof(CustomizationWindowViewConfiguration), menuName = "Window/Configurations/" + nameof(CustomizationWindowViewConfiguration))]
public class CustomizationWindowViewConfiguration : ViewConfiguration<IWindowViewModel, WindowViewModel, CustomizationWindowView>
{
	public List<GameObject> CustomizationOptions;
    protected override void Configure(WindowViewModel viewModel, CustomizationWindowView view)
	{
		for (int i = 0; i < CustomizationOptions.Count; i++)
		{
			GameObject CustomizationOption = Container.InstantiatePrefab(CustomizationOptions[i], view.OptionParenTransform);
			view.CustomizationOptions.Add(CustomizationOption);
		}
    }
}
