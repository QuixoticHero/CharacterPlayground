using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "CharacterCameraGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Kinematic/CharacterCamera",
	    order = 120)]
	public sealed class CharacterCameraGameEvent : GameEventBase<KinematicCharacterController.Examples.CharacterCamera>
	{
	}
}