using UnityEngine;

namespace Bipolar.PhysicsEvents
{
    public sealed class CollisionExitEvent : Collision3DEvent
    {
        private void OnCollisionExit(Collision collision) => TryInvokeEvent(collision);
    }
}
