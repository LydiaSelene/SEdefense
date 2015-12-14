using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour {

	Transform thistransform;
	public int health;

	// Use this for initialization
	void Start () {
		thistransform = transform;
		health = 10;
	}
	
	// Update is called once per frame
	void Update () {
		thistransform.Translate (new Vector3 (-0.3f, 0, 0));
	}

	public void onDeath(){
		Debug.Log("tot");
		Destroy (gameObject);
	}
}
