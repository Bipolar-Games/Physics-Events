using UnityEngine;

namespace Bipolar.PhysicsEvents
{
    public sealed class TriggerExitEvent : TriggerEvent<Collider>
    {
        private void OnTriggerExit(Collider collision) => TryInvokeEvent(collision);
    }
}
