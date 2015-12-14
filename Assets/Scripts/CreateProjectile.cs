using UnityEngine;
using System.Collections;

public class CreateProjectile : MonoBehaviour {

	public GameObject Prefab;
	GameObject obj;

	// Use this for initialization
	void Start () {
	
	}

	public void create(){
		obj = GameObject.Instantiate (Prefab);
		obj.transform.position = transform.position;
		obj.transform.rotation = Quaternion.identity;
	}
	
	// Update is called once per frame
	void Update () {

		if (obj != null) {
			obj.transform.position = new Vector3 (obj.transform.position.x,obj.transform.position.y+0.3f,obj.transform.position.z-1f);
		}
	
	}
}
