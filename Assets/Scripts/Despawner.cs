using UnityEngine;
using System.Collections;

public class Despawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
		
	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log("trigger");
		if (other.tag.Equals ("FlyingEnemy") || other.tag.Equals ("groundEnemy") ) {
			//Debug.Log("despawn");
			other.SendMessage ("onDespawn");
			GetComponent<Player_Attributes> ().onHit();

		}
	}


	// Update is called once per frame
	void Update () {

	}

}
