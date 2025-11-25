using UnityEngine;
using System.Collections;


public class PrefabSpawner : MonoBehaviour {
    public GameObject good_prefab;
    public GameObject bad_prefab;
    public Transform spawn_pos;
    public float delay;

    public bool istarted = false;

    private int streak;
    public void Started()
    {
        if (!istarted) 
        {
            istarted = true;
            StartCoroutine(Spawning());
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
            Instantiate(RandomPrefab(), spawn_pos.position, Quaternion.Euler(0,-90,0));
            yield return new WaitForSeconds(delay);
        }
    }
}