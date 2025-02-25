using UnityEngine;

namespace Bipolar.PhysicsEvents
{
	public class CharacterControllerHitEvent : CollisionEvent<ControllerColliderHit>
	{
		protected override GameObject GetGameObject(ControllerColliderHit data) => data.gameObject;

		private void OnControllerColliderHit(ControllerColliderHit hit) => TryInvokeEvent(hit);
	}
}
