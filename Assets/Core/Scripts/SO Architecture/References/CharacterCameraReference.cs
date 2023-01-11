using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class CharacterCameraReference : BaseReference<KinematicCharacterController.Examples.CharacterCamera, CharacterCameraVariable>
	{
	    public CharacterCameraReference() : base() { }
	    public CharacterCameraReference(KinematicCharacterController.Examples.CharacterCamera value) : base(value) { }
	}
}