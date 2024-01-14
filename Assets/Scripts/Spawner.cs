using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject barrelPrefab;
	public float minSpawnTime = 2.0f;
	public float maxSpawnTime = 4.0f;
    
    void Start()
    {
	    Spawn();   
    }

    
	void Spawn()
    {
	    Instantiate(barrelPrefab, transform.position, Quaternion.identity);
	    Invoke(nameof(Spawn), Random.Range(minSpawnTime, maxSpawnTime));
    }
}
