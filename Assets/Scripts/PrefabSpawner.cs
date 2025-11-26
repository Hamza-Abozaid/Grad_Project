using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PrefabSpawner : MonoBehaviour {
    public GameObject good_prefab;
    public GameObject bad_prefab;
    public Transform spawn_pos;
    public float delay;

    public bool istarted = false;

    public List<GameObject> active_objects = new List<GameObject>();

    private int streak;

    private void Start()
    {
        if (istarted)
        {
            StartCoroutine(Spawning());
        }
    }
    public void Started()
    {
        if (!istarted) 
        {
            istarted = true;
            StartCoroutine(Spawning());
        }
    }

    public void ClearAvtiveObjects()
    {
        foreach (var obj in active_objects)
        {
            Destroy(obj);
        }
    }


    GameObject RandomPrefab() 
    {
        if (streak >= 5) 
        {
            streak = 0;
            return bad_prefab;
        }

        if (Random.value <= 0.3f) {
            streak = 0;
            return bad_prefab;
        } 
        else 
        {
            streak++;
            return good_prefab;
        }
    }

    IEnumerator Spawning() 
    {
        while (true) 
        {
            GameObject spawned_object = Instantiate(RandomPrefab(), spawn_pos.position, Quaternion.Euler(0,-90,0));
            active_objects.Add(spawned_object);
            yield return new WaitForSeconds(delay);
        }
    }
}