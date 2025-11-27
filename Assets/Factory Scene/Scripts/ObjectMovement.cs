using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed;

    private bool is_selected = false;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (!is_selected) 
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    public void SetIsSelected(bool val) 
    {
        is_selected = val;
    }
}
