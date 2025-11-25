using UnityEngine;

public class ObjectState : MonoBehaviour
{
    public State current_state;
    public enum State
    {
        Good,
        Bad
    }
}
