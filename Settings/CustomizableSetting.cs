using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CustomizableSetting : ScriptableObject
{
    public abstract void ApplySetting(GameObject gameObject);
}
