using System;
using System.Collections;
using System.Collections.Generic;
using LunarByte.MVVM;
using UnityEngine;
using UnityEngine.UI;

public class CustomizationOptionView : View<ICustomizationOptionViewModel>
{
	[SerializeField] private Button SelectButton;
	[SerializeField] private Button LockStateButton;
	[SerializeField] private bool isLocked;

    protected override void OnViewAwake()
	{
		base.OnViewAwake();
		SelectButton.onClick.AddListener(OnSelectButtonPressed);
		LockStateButton.onClick.AddListener(OnLockStateButtonPressed);
	}

    public void OnSelectButtonPressed()
	{
        if(!isLocked)
        {
	        ViewModel.SetPlayerVisuals.Dispatch();
        }

        else
        {
            Debug.LogError("Option is locked", this);
        }
	}

	public void SetLockedState(bool state)
	{
		isLocked = state;
		SelectButton.gameObject.SetActive(!state);
		LockStateButton.gameObject.SetActive(state);
	}

	public void OnLockStateButtonPressed()
	{
		//TODO: Add functionality to show popup that displays object lock state and how to unlock it / buy it
	}
}
