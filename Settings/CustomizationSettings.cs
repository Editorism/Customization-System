using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Used to set the customizable components of the Game Object and to define the Customization Options
/// </summary>
[CreateAssetMenu(fileName = nameof(CustomizationSettings), menuName = "Customization/Settings/" + nameof(CustomizationSettings))]
public class CustomizationSettings : ScriptableObject
{
	public List<CustomizableSetting> Settings;
}
