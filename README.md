# Customization System for Unity Games
A system for creating customization menus and functionality in Unity
```diff
- Requires LunarByte.MVVM to work
```

This system was made for LunarByte during my internship in the summer of 2019. It uses LunarByte's proprietary MVVM framework.

## How the system is used
As the system will not work as is, the basic functionality and implementation method is described below
### Defining the customizable components of a Game Object
Create a CustomizationSettings ScriptableObject instance from Asset Menu for the customizable Game Object and for each customization option. Customization Settings are used to define the components that are changeable in-game, using manually created ScriptableObjects that inherit from the abstract class CustomizableSetting. For example: CustomizableMesh:
```
[CreateAssetMenu(fileName = nameof(CustomizableMesh), menuName = "Customization/Settings/" + nameof(CustomizableMesh))]
public class CustomizableMesh : CustomizableSetting
{
	public Mesh Mesh;

	public override void ApplySetting(GameObject gameObject)
	{
		gameObject.GetComponent<MeshFilter>().mesh = Mesh;
	}
}
```
Attach the GameObject customization settings to the CustomizationModelConfig ScriptableObject instance, which is then attached to either the SceneContext or ProjectContext (part of Zenject).

### Adding the CustomizationView to a Game Object
The view uses Lunarbyte.MVVM, and needs the attached Game Object to also have a GameObjectContext.cs component (part of Zenject), that has the relevant ViewConfiguration attatched as a Scriptable Object Installer. The GameObject Inspector should look like this:

![PreviewObjectScreenshot](https://user-images.githubusercontent.com/7835977/62126531-8d9bf880-b2d8-11e9-9e0b-f38543dbcc06.png)

### Creating Customization Option UI-elements
The Customization Window View Configuration takes a list of Customization Option prefabs. The Options are meant to be placed in the UI. In its current implementation in LunarByte games, the Customization Window View takes a Transform reference and Instantiates the customization option prefabs as children of that Transform. This is for populating a Layout Group, eg. GridLayoutGroup, something like this:

![Screenshot2](https://user-images.githubusercontent.com/7835977/62125044-94c10780-b2d4-11e9-8275-d15b82f05eb0.png)

*The Customization Option prefabs are laid out in a GridLayoutGroup.*

The Customization Settings specific to each Customization Option has to be attached to the CustomizationOptionViewConfiguration instance in order to bind the dependency between the Option and the customizable Game Object correctly.

## Function
The Scene hierarchy is set up with a preview 3D-object that is rendered into a render texture used by a preview image, and a scroll view with a grid layout group in its content that takes in all the different customization options.

![CustomizationExampleScene](https://user-images.githubusercontent.com/7835977/62193520-9516dc80-b380-11e9-8bce-792df7d68824.png)
*The PreviewObject's mesh component is bound to the CustomizationModel's CustomizationSettings, which includes a mesh.*

The binding of a customizable GameObject's components to the CustomizationModel's CustomizationSettings looks like this:
```
protected override void Configure(CustomizationViewModel viewModel, CustomizationView view, CustomizationModel model)
    	{
	    view.Bind<CustomizationView, CustomizationSettings>(view.SetCustomizationOptions)
		    .ToProperty(model, m => m.CustomizationSettings, nameof(CustomizationModel.CustomizationSettings));
   	}
 ```
 
 Each CustomizationOptionView is then bound to the CustomizationModel's CustomizationSettings:
 ```
 protected override void Configure(CustomizationOptionViewModel viewModel, CustomizationOptionView view, CustomizationModel cModel)
	{
		viewModel.CustomizationSettings = Settings;

		viewModel.SetPlayerVisualsEvent.AddListener(() => cModel.ChangeCosmeticSettings(viewModel.CustomizationSettings));	
	}
 ```

With the Scene hierarchy set up and the dependency bindings done, the end result looks like this:

![CustomizationDemo](https://user-images.githubusercontent.com/7835977/62138835-fd1de200-b2f0-11e9-9769-83f6f476156c.gif)


