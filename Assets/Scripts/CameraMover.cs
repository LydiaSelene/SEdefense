using UnityEngine;
using System.Collections;
/*
Diese Klasse steuert das Verhalten der Orthographischen Kamera.
Mit einem Rechtsklick kann man die Kamera verschieben und sich über das SPielfeld bewegen.
Dabei sorgt dieses Script dafür, dass sich die Kamera niemals über das Spielfeld hinaus bewegt.
*/
public class CameraMover : MonoBehaviour {

	public float panSpeed = 1.0f;
	private bool isPanning;
	private Vector3 mouseOrigin;
	private Vector3 mousePos;
	private float leftBorder;
	private float rightBorder;
	private float upperBorder;
	private float lowerBorder;
	private float vertBorder;
	private float horBorder;
	private float mapX = 135.0f;
	private float mapY = 100.0f;
	private Vector3 movement;

	// Berechne die Position der Orthographischen Kamera und die Grnezen des SPielfeldes relativ zur Kamera
	void Start () {

		movement = new Vector3 (0,0,0);
		vertBorder = Camera.main.orthographicSize * 2f;
		horBorder = vertBorder * Screen.width / Screen.height;

		leftBorder = horBorder - mapX / 2.0f;
		rightBorder = mapX / 2.0f - horBorder;
		lowerBorder = vertBorder - mapY / 2.0f;
		upperBorder = mapY / 2.0f - vertBorder;
	}
	
	// Die Mausposition wird hier überprüft und die Kamera entsprechend dazu verschoben
	void Update () {
		mousePos = Camera.main.ScreenToViewportPoint (new Vector3(Input.mousePosition.x,Input.mousePosition.y));
		
		//ein Rechtklick "greift" das Spielfeld und bewegt es
		if (Input.GetMouseButtonDown(1)){
			mouseOrigin = Input.mousePosition;
			isPanning = true;
		}
		if (!Input.GetMouseButton (1)) {
			isPanning = false;
		}

		//wird das spielfeld gerade bewegt, muss die position berechnet werden, damit die kamera niemals das spielfeld verlässt
		if (isPanning) {
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
			
			//mathf.clamp hält den wert x zwischen den min und max variablen: Clamp(wert, min, max)
			pos.x = Mathf.Clamp(pos.x, leftBorder, rightBorder);
			pos.y = Mathf.Clamp (pos.y, lowerBorder, upperBorder);

			Vector3 move = new Vector3 (pos.x * panSpeed, pos.y * panSpeed, 0);

			//vor der translation wird überprüft, ob die kamera das spielfeld verlassen würde
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
