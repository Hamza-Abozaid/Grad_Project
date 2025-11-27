using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketChecker : MonoBehaviour
{
    public UnityEvent OnGoodDisposed;
    public UnityEvent OnBadDisposed;


    public void OnObjectSocketed(SelectEnterEventArgs args)
    {
        var interactable = args.interactableObject.transform.gameObject;

        var state = interactable.GetComponent<ObjectState>().current_state;

        switch (state)
        {
            case ObjectState.State.Good:
                OnGoodDisposed.Invoke();
                Destroy(interactable, 2);
                MiddleMan.Instance.Spawner.active_objects.Remove(interactable);
                break;
            case ObjectState.State.Bad:
                OnBadDisposed.Invoke();
                Destroy(interactable, 2);
                MiddleMan.Instance.Spawner.active_objects.Remove(interactable);
                break;
        }
    }
}
