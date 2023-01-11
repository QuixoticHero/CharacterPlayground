using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "CharacterController")]
	public sealed class CharacterControllerGameEventListener : BaseGameEventListener<KinematicCharacterController.Examples.CharacterController, CharacterControllerGameEvent, CharacterControllerUnityEvent>
	{
	}
}