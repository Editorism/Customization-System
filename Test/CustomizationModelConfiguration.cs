using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM.Configurations;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(CustomizationModelConfiguration),
	menuName = "Customization/Configurations/ModelConfiguration")]
public class CustomizationModelConfiguration : ModelConfiguration<ICustomizationModel, CustomizationModel>
{
	[SerializeField] private CustomizationSettings settings;
	protected override void Configure(CustomizationModel model)
	{
		model.CustomizationSettings = settings;
	}
}
