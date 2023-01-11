using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "CharacterCamera")]
	public sealed class CharacterCameraGameEventListener : BaseGameEventListener<KinematicCharacterController.Examples.CharacterCamera, CharacterCameraGameEvent, CharacterCameraUnityEvent>
	{
	}
}