using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour {

	public float panSpeed = 1.0f;
	private bool isPanning;
	private Vector3 mouseOrigin;
	private Vector3 mousePos;
	private float leftBorder = -7.0f;
	private float rightBorder = 41.0f;
	private float upperBorder = - 10.9f;
	private float lowerBorder = 43.5f;
	private float vertBorder;
	private float horBorder;
	private float mapX = 100.0f;
	private float mapY = 100.0f;
	private Vector3 movement;

	// Use this for initialization
	void Start () {

		movement = new Vector3 (0,0,0);
		vertBorder = Camera.main.orthographicSize * 2f;
		horBorder = vertBorder * Screen.width / Screen.height;

		leftBorder = horBorder - mapX / 2.0f;
		rightBorder = mapX / 2.0f - horBorder;
		lowerBorder = vertBorder - mapY / 2.0f;
		upperBorder = mapY / 2.0f - vertBorder;
	}
	
	// Update is called once per frame
	void Update () {
		mousePos = Camera.main.ScreenToViewportPoint (new Vector3(Input.mousePosition.x,Input.mousePosition.y));
		if (Input.GetMouseButtonDown(0)){
			mouseOrigin = Input.mousePosition;
			isPanning = true;
		}
		if (!Input.GetMouseButton (0)) {
			isPanning = false;
		}


		if (isPanning) {
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
			//Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

			//Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
			pos.x = Mathf.Clamp(pos.x, leftBorder, rightBorder);
			pos.y = Mathf.Clamp (pos.y, lowerBorder, upperBorder);

			Vector3 move = new Vector3 (pos.x * panSpeed, pos.y * panSpeed, 0);

			Vector3 presumedPos = transform.position + move;
			if (!(presumedPos.x < leftBorder || presumedPos.x > rightBorder)) {
				transform.Translate (new Vector3(move.x,0,0), Space.Self);
			}
			if (!(presumedPos.y < lowerBorder || presumedPos.y > upperBorder)) {
				transform.Translate (new Vector3(0,move.y,0), Space.Self);
			}
				
		}

	
	}
}
