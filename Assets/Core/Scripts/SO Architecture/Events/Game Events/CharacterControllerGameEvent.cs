using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "CharacterControllerGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Kinematic/CharacterController",
	    order = 120)]
	public sealed class CharacterControllerGameEvent : GameEventBase<KinematicCharacterController.Examples.CharacterController>
	{
	}
}