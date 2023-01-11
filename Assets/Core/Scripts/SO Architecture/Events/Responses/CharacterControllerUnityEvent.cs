using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class CharacterControllerUnityEvent : UnityEvent<KinematicCharacterController.Examples.CharacterController>
	{
	}
}