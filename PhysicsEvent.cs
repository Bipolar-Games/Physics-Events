using UnityEngine;
using UnityEngine.Events;

namespace Bipolar.PhysicsEvents
{
    public abstract class PhysicsEventBase<T> : MonoBehaviour
        where T : class
    {
        public delegate void PhysicsEventHandler(T collision);

        private event PhysicsEventHandler invokedActions;

#if NAUGHTY_ATTRIBUTES
		[NaughtyAttributes.Tag]
#endif
        [SerializeField]
        [Tooltip("Specify tags to check. If empty: all tags will trigger the event")]
        private string[] detectedTags;

        [Space, SerializeField]
        private UnityEvent onEventHappen = new UnityEvent();

        public void AddListener(PhysicsEventHandler action)
        {
            invokedActions += action;
        }

        public void RemoveListener(PhysicsEventHandler action)
        {
            invokedActions -= action;
        }

        public void Clear()
        {
			invokedActions = null;
        }

		protected abstract GameObject GetGameObject(T data);

		protected void InvokeEvents(T data)
        {
            onEventHappen.Invoke();
            invokedActions?.Invoke(data);
        }

        protected bool CompareTag(GameObject other)
        {
            if (detectedTags == null || detectedTags.Length <= 0)
                return true;

            for (int i = 0; i < detectedTags.Length; i++)
                if (other.CompareTag(detectedTags[i]))
                    return true;

            return false;
        }

        protected void TryInvokeEvent(T data)
        {
            if (CompareTag(GetGameObject(data)))
                InvokeEvents(data);
        }
    }

    public abstract class TriggerEvent<TCollider> : PhysicsEventBase<TCollider>
        where TCollider : Component
    {
		protected override GameObject GetGameObject(TCollider collider) => collider.gameObject;
    }

    public abstract class CollisionEvent<TCollision> : PhysicsEventBase<TCollision>
        where TCollision : class
    { }

    public abstract class Collision2DEvent : CollisionEvent<Collision2D>
    {
		protected override GameObject GetGameObject(Collision2D data) => data.gameObject;
	}

    public abstract class Collision3DEvent : CollisionEvent<Collision>
    {
		protected override GameObject GetGameObject(Collision data) => data.gameObject;
	}
}
