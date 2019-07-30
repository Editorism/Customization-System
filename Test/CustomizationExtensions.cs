using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CustomizationExtensions
{
	public static void ChangeCustomizationSettings(this CustomizationModel model, CustomizationSettings settings)
	{
		model.CustomizationSettings = settings;
	}
}
