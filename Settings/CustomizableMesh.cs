using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(CustomizableMesh), menuName = "Customization/Settings/" + nameof(CustomizableMesh))]
public class CustomizableMesh : CustomizableSetting
{
	public Mesh Mesh;

	public override void ApplySetting(GameObject gameObject)
	{
		gameObject.GetComponent<MeshFilter>().mesh = Mesh;
	}
}

