using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class initiateWandTower : MonoBehaviour {

	public GameObject prefab;
	public bool hold;
	public float mousePosX;
	public float mousePosY;


	// Use this for initialization
	void Start () {
		hold = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (hold) {
				Debug.Log("hold");
				mousePosX = Input.mousePosition.x;
				mousePosY = Input.mousePosition.y;
				//var objectPos = Input.mousePosition/100;
				var objectPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePosX, mousePosY,1));
				GameObject obj = Instantiate(prefab, objectPos, Quaternion.identity) as GameObject;
				hold = false;
			}
		}
	}

	public void InstantiateWandTower(){
		hold = true;
	}
}
