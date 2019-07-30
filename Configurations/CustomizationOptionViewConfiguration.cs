using System.Collections;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Multiplayer;
using LunarByte.MVVM;
using LunarByte.MVVM.Configurations;
using UnityEngine;

/// <summary>
/// Used for binding the dependencies of the Customization Option View
/// </summary>
[CreateAssetMenu(fileName = nameof(CustomizationOptionViewConfiguration), menuName = "Customization Option/Configurations/" + nameof(CustomizationOptionViewConfiguration))]
public class CustomizationOptionViewConfiguration : ViewConfiguration<ICustomizationOptionViewModel, CustomizationOptionViewModel, CustomizationOptionView, CustomizationModel>
{
    
	[SerializeField] private CustomizationSettings Settings;
	protected override void Configure(CustomizationOptionViewModel viewModel, CustomizationOptionView view, CustomizationModel cModel)
	{
		viewModel.CustomizationSettings = Settings;

		viewModel.SetPlayerVisualsEvent.AddListener(() => cModel.ChangeCosmeticSettings(viewModel.CustomizationSettings));

		
    }
}
