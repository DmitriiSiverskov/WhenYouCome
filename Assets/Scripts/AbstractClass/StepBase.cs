using UnityEngine;

namespace AbstractClass
{
    public abstract class StepBase : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            GlobalEvent.Player.Event.Step.Invoke(other.tag);
        }
    }
}