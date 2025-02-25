using UnityEngine;

namespace Bipolar.PhysicsEvents
{
    public sealed class CollisionStayEvent : Collision3DEvent
    {
        private void OnCollisionStay(Collision collision) => TryInvokeEvent(collision);
    }
}
