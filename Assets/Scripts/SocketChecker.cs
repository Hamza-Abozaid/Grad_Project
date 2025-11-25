using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class SocketChecker : MonoBehaviour
{

    public UnityEvent OnGoodDisposed;
    public UnityEvent OnBadDisposed;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Box")) 
        {
            var state = other.gameObject.GetComponent<ObjectState>().current_state;

            if (state == ObjectState.State.Good) {
                OnGoodDisposed.Invoke();
                StartCoroutine(DestroySocketedObject(other.gameObject));
            } 
            else 
            {
                OnBadDisposed.Invoke();
                StartCoroutine(DestroySocketedObject(other.gameObject));
            }
        }
    }

    IEnumerator DestroySocketedObject(GameObject var) 
    {
        yield return new WaitForSeconds(2f);
        Destroy(var);
    }

}
