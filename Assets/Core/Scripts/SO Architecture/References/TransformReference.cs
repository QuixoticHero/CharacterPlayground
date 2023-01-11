using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class TransformReference : BaseReference<Transform, TransformVariable>
	{
	    public TransformReference() : base() { }
	    public TransformReference(Transform value) : base(value) { }
	}
}