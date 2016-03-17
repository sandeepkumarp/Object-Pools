using UnityEngine;
using System.Collections;

public class StuffSpawner : MonoBehaviour
{

	public float timeBetweenSpawns;
	public Stuff[] stuffPrefabs;
	float timeSinceLastSpawn;

	public float velocity;

	void FixedUpdate ()
	{
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn >= timeBetweenSpawns) {
			timeSinceLastSpawn -= timeBetweenSpawns;
			SpawnStuff ();
		}
	}

	void SpawnStuff ()
	{
		Stuff prefab = stuffPrefabs [Random.Range (0, stuffPrefabs.Length)];
		Stuff spawn = Instantiate<Stuff> (prefab);
		spawn.transform.localPosition = transform.position;
		spawn.Body.velocity = transform.up * velocity;
	}
}
