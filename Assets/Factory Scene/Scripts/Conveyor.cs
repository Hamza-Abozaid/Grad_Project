using UnityEngine;

public class Conveyor : MonoBehaviour {
    [SerializeField] private Material targetmaterial;

    [SerializeField] private float speed;

    public bool isstarted = false;
    private Vector2 offset;


    public void SetIsStarted(bool val) {
        isstarted = val;
    }

    private void FixedUpdate() {
        if (!isstarted)
            return;


        MoveMaterial();

    }


   

    public void MoveMaterial() {
        offset = targetmaterial.GetTextureOffset("_BaseMap");
        offset.y += speed;
        targetmaterial.SetTextureOffset("_BaseMap", offset);
    }
}
