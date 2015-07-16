using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public float maxHeight = 1.7f;
	public float minHeight = -4.1f;
	public float maxSize = 7.5f;
	public float minSize = 2.5f;

	// Use this for initialization
	void Start () {
		Spawn();
	}

	void Spawn(){
		Vector3 v = new Vector3(transform.position.x + Random.Range(minSize,maxSize), Random.Range(minHeight,maxHeight), transform.position.z);
		//Instantiate(obj[Random.Range (0,obj.GetLength (0))], transform.position, Quaternion.identity);
		//Instantiate(obj[Random.Range (0,obj.GetLength (0))], v, Quaternion.identity);
		Object platform = Instantiate(obj[Random.Range (0,obj.GetLength (0))], v, Quaternion.identity);
		//make sure that platforms are certain distance apart

		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
