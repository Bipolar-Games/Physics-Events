using UnityEngine;

namespace Bipolar.PhysicsEvents
{
    public sealed class CollisionEnterEvent : Collision3DEvent
    {
        private void OnCollisionEnter(Collision collision) => TryInvokeEvent(collision);
    }
}
