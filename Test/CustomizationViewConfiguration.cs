using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using LunarByte.MVVM.Configurations;
using UnityEngine;

/// <summary>
/// Used to bind the dependencies of the Customization View
/// </summary>
[CreateAssetMenu(fileName = nameof(CustomizationViewConfiguration),
	menuName = "Customization/Configurations/" + nameof(CustomizationViewConfiguration))]
public class CustomizationViewConfiguration : ViewConfiguration<ICustomizationViewModel, CustomizationViewModel, CustomizationView, CustomizationModel>
{
	protected override void Configure(CustomizationViewModel viewModel, CustomizationView view, CustomizationModel model)
    {
	    view.Bind<CustomizationView, CustomizationSettings>(view.SetCustomizationOptions)
		    .ToProperty(model, m => m.CustomizationSettings, nameof(CustomizationModel.CustomizationSettings));

    }
}
