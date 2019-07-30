using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(CustomizableMaterial), menuName = "Customization/Settings/" + nameof(CustomizableMaterial))]
public class CustomizableMaterial : CustomizableSetting
{
	public Material Material;

	public override void ApplySetting(GameObject gameObject)
	{
		gameObject.GetComponent<MeshRenderer>().material = Material;
	}
}
