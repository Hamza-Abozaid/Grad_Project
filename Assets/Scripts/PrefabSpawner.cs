using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class PrefabSpawner : MonoBehaviour {
    public GameObject prefab;
    public Transform spawn_pos;
    public float delay;

    public bool istarted = false;

    public void Started()
    {
        if (!istarted) 
        {
            istarted = true;
            StartCoroutine(Spawning());
        }
    }

    IEnumerator Spawning() 
    {
        while (true) 
        {
            Instantiate(prefab, spawn_pos.position, Quaternion.Euler(0,-90,0));
            yield return new WaitForSeconds(delay);
        }
    }
}