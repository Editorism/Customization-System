using System;
using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using UnityEngine;

public class CustomizationView : View<ICustomizationViewModel>
{
	[SerializeField] private GameObject CustomizableObject;
	
	public void SetCustomizationOptions(CustomizationSettings settings)
	{

		foreach (CustomizableSetting setting in settings.Settings)
		{
			setting.ApplySetting(CustomizableObject);
		}
	}
}
