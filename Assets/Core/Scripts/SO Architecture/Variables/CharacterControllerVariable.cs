using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class CharacterControllerEvent : UnityEvent<KinematicCharacterController.Examples.CharacterController> { }

	[CreateAssetMenu(
	    fileName = "CharacterControllerVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Kinematic/CharacterController",
	    order = 120)]
	public class CharacterControllerVariable : BaseVariable<KinematicCharacterController.Examples.CharacterController, CharacterControllerEvent>
	{
	}
}