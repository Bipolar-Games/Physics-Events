using UnityEngine;

namespace Bipolar.PhysicsEvents
{
    public sealed class TriggerStayEvent : TriggerEvent<Collider>
    {
        private void OnTriggerStay(Collider collision) => TryInvokeEvent(collision);
    }
}
