using UnityEngine;

namespace Bipolar.PhysicsEvents
{
    public sealed class CollisionStay2DEvent : Collision2DEvent
    {
        private void OnCollisionStay2D(Collision2D collision) => TryInvokeEvent(collision);
    }
}
