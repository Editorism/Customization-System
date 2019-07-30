using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using UnityEngine;
using Event = LunarByte.MVVM.Event;

public class CustomizationViewModel : ViewModel, ICustomizationViewModel
{
}

public interface ICustomizationViewModel : IObservableProperties
{
}
