using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

	public GameObject monsterPrefab;
	float spawnTimer;
	List<Vector3> waypoints;

	// Use this for initialization
	void Start () {
	
		spawnTimer = 2.0f;
		waypoints = new List<Vector3> ();
		Transform wayPointsChild = transform.GetChild (0);
		for (int i = 0; i < wayPointsChild.childCount; i++) {
			waypoints.Add(wayPointsChild.GetChild(i).transform.position);
		}

	}
	
	// Update is called once per frame
	void Update () {

		spawnTimer = spawnTimer - (Time.deltaTime % 60);
		if (spawnTimer <= 0) {
			GameObject m = GameObject.Instantiate (monsterPrefab);
			m.transform.position = transform.position;
			m.transform.rotation = Quaternion.identity;
			m.SendMessage ("setWaypoints", waypoints, SendMessageOptions.RequireReceiver );
			spawnTimer = 3.0f;
		}
	}
}
