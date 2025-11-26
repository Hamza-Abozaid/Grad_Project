using UnityEngine;
using UnityEngine.Events;

public class SocketChecker : MonoBehaviour
{
    public UnityEvent OnGoodDisposed;
    public UnityEvent OnBadDisposed;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Box")) 
        {
            var state = other.gameObject.GetComponent<ObjectState>().current_state;

            if (state == ObjectState.State.Good) {
                OnGoodDisposed.Invoke();
                Destroy(other.gameObject, 2);
                MiddleMan.Instance.Spawner.active_objects.Remove(other.gameObject);
            } 
            else 
            {
                OnBadDisposed.Invoke();
                Destroy(other.gameObject, 2);
                MiddleMan.Instance.Spawner.active_objects.Remove(other.gameObject);
            }
        }
    }


}
