using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "Transform")]
	public sealed class TransformGameEventListener : BaseGameEventListener<Transform, TransformGameEvent, TransformUnityEvent>
	{
	}
}