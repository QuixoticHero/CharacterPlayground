using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class CharacterCameraEvent : UnityEvent<KinematicCharacterController.Examples.CharacterCamera> { }

	[CreateAssetMenu(
	    fileName = "CharacterCameraVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Kinematic/CharacterCamera",
	    order = 120)]
	public class CharacterCameraVariable : BaseVariable<KinematicCharacterController.Examples.CharacterCamera, CharacterCameraEvent>
	{
	}
}