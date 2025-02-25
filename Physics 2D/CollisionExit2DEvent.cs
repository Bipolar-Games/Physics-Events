using UnityEngine;

namespace Bipolar.PhysicsEvents
{
    public sealed class CollisionExit2DEvent : Collision2DEvent
    {
        private void OnCollisionExit2D(Collision2D collision) => TryInvokeEvent(collision);
    }
}
