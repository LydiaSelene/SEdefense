using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject monsterPrefab;
	float spawnTimer;

	// Use this for initialization
	void Start () {
	
		spawnTimer = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {

		spawnTimer = spawnTimer - (Time.deltaTime % 60);
		if (spawnTimer <= 0) {
			GameObject m = GameObject.Instantiate (monsterPrefab);
			m.transform.position = transform.position;
			m.transform.rotation = Quaternion.identity;
			spawnTimer = 2.0f;
		}
	}
}
