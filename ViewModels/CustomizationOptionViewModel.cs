using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using UnityEngine;
using Event = LunarByte.MVVM.Event;

public class CustomizationOptionViewModel : ViewModel, ICustomizationOptionViewModel
{
	private CustomizationSettings CustomizationSettingsField;
	public Event SetPlayerVisualsEvent = new Event();

	public CustomizationSettings CustomizationSettings
	{
		get { return CustomizationSettingsField; }
		set { CustomizationSettingsField = value; }
	}

	public IDispatchableEvent SetPlayerVisuals
	{
		get { return SetPlayerVisualsEvent; }
	}
}

public interface ICustomizationOptionViewModel : IObservableProperties
{
	CustomizationSettings CustomizationSettings { get; }
	IDispatchableEvent SetPlayerVisuals { get; }
}
