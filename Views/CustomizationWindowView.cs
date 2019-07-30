using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizationWindowView : GameWindowView<IWindowViewModel>
{
	public Button ExitButton;
	public List<GameObject> CustomizationOptions;
	public Transform OptionParenTransform;

    protected override void OnViewAwake()
	{
		base.OnViewAwake();
		ExitButton.onClick.AddListener(TransitionToGame);
	}

	void OnEnable()
	{
		Debug.Log("Enabled Customization Menu Window");
	}

	public void TransitionToGame()
	{
		ViewModel.CloseWindowEvent.Dispatch(ButtonType.ToMainWindow);
	}
}
