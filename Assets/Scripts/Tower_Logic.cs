using UnityEngine;
using System.Collections;

public class Tower_Logic : MonoBehaviour {

	Transform thistransform;
	//der Projektil-Typ, den dieser Turm verwendet, z.B. Kanonenkugel oder Pfeil
	public GameObject usedProjectilePrefab;
	//Intervall in Sekunden. Wenn der Turm feuert, muss diese Zeit ablaufen, bis er erneut feuern kann.
	float fireIntervall;
	//Ziel- oder Feuerradius des Turms
	float range;

	//wird ausgeführt, wenn eine Instanz geladen wird
	void Awake(){
		thistransform = transform;
		fireIntervall = 1.0f;
		range = GetComponent<CircleCollider2D>().radius;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public GameObject getUsedProjectile(){
		return this.usedProjectilePrefab;
	}

	public float getFireIntervall(){
		return this.fireIntervall;
	}

	public float getRange(){
		Debug.Log("radius:"+range);
		return range;
	}
}
