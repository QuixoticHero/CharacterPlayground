using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class CharacterControllerReference : BaseReference<KinematicCharacterController.Examples.CharacterController, CharacterControllerVariable>
	{
	    public CharacterControllerReference() : base() { }
	    public CharacterControllerReference(KinematicCharacterController.Examples.CharacterController value) : base(value) { }
	}
}