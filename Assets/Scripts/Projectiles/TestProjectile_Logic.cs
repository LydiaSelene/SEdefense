using UnityEngine;
using System.Collections;

public class TestProjectile_Logic : MonoBehaviour {

	Vector3 direction;
	float speed;

	//wird ausgeführt, wenn eine Instanz geladen wird
	void Awake(){
		speed = 20.0f;
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("proj.start ausgeführt");
	}

	public void setup(Vector3 spawnPosition, Vector3 direction){
		Debug.Log ("proj.setup ausgeführt");

		this.direction = direction.normalized;
		transform.position = spawnPosition;
		transform.rotation = Quaternion.identity;
		//rotation entsprechend richtungsvektor
	}
	
	// Update is called once per frame
	void Update () {
		
			//obj.transform.Translate (direction*Time.deltaTime, Space.World);
			transform.Translate (direction*speed*Time.deltaTime, Space.World);	
	}
}
