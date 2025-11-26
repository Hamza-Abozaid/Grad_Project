using UnityEngine;

public class MiddleMan : MonoBehaviour
{
    public static MiddleMan Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public PrefabSpawner Spawner;
}
