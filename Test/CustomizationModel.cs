using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using UnityEngine;

public class CustomizationModel : Model, ICustomizationModel
{
	private CustomizationSettings CustomizationSettingsField;

	public CustomizationSettings CustomizationSettings
    {
		get { return CustomizationSettingsField; }
		set
		{
			CustomizationSettingsField = value;
			OnPropertyChanged();
		}
	}
}

public interface ICustomizationModel : IObservableProperties
{
	CustomizationSettings CustomizationSettings { get; }
}
