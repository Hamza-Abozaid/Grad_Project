using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.localPosition += new Vector3(speed * Time.deltaTime, 0, 0);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
