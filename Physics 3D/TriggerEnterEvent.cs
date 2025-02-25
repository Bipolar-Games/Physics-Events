using UnityEngine;

namespace Bipolar.PhysicsEvents
{
    public sealed class TriggerEnterEvent : TriggerEvent<Collider>
    {
        private void OnTriggerEnter(Collider collision) => TryInvokeEvent(collision);
    }
}
