using UnityEngine;
using System.Collections;

public class TowerA : MonoBehaviour {

	Transform thistransform;

	//Intervall in Sekunden. Wenn der Turm feuert, muss diese Zeit ablaufen, bis er erneut feuern kann.
	float fireIntervall;
	float actualIntervallTime;

	//der Projektil-Typ, den dieser Turm verwendet, z.B. Kanonenkugel oder Pfeil
	public GameObject projectilePrefab;
	TestProjectile projectileScript;

	//Ziel- oder Feuerradius des Turms
	float radius;

	Collider2D targetEnemy;
	//sagt, ob der Turm schon oder noch ein Ziel hat
	bool hasTarget;


	//wird ausgeführt, wenn eine Instanz geladen wird
	void Awake(){
	}

	// Use this for initialization
	void Start () {
		thistransform = gameObject.transform;

		fireIntervall = 0.5f;
		actualIntervallTime = 0.0f;
		radius = 8f;
		//radius = GetComponent<CircleCollider2D>().radius;
		hasTarget = false;
		projectileScript = projectilePrefab.GetComponent<TestProjectile>();

	}

	void searchTarget(){
		Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, radius);
		//Gegner unter den Collidern suchen
		foreach (Collider2D c in colliders) {
			if (c.tag.Equals ("FlyingEnemy")) {
				//auf den ersten Gegner feuern
				targetEnemy = c;
				hasTarget = true;
				break;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collider){
		Debug.Log ("Treffer");
	}
		
	
	// Update is called once per frame
	void Update () {

		if(actualIntervallTime > 0f){
			actualIntervallTime = actualIntervallTime - Time.deltaTime;
		}


		//schauen, ob das Ziel noch in Reichweite ist oder gelöscht wurde
		if(hasTarget){
			if (targetEnemy == null) {
				hasTarget = false;
			} else {
				float distanceToTarget = Vector3.Distance(transform.position, targetEnemy.transform.position);
				if(distanceToTarget > radius){
					hasTarget = false; 
					//targetEnemy = null;
				}
			}
		}

		//sucht nur Ziele, wenn es kein akutelles Ziel gibt.
		if (!hasTarget) {
			searchTarget ();
		}

		//immer ausführen
		if (hasTarget) {
			Vector3 vecToEnemy = targetEnemy.transform.position - thistransform.position;

			//evtl. vorhalten: bewegungsgeschw. * flugzeit des projektils + position gegner

			//Geschütz etc ausrichten, Vektor: gegner - eigene pos
			//if has rotatable base...

			//feuern
			if (actualIntervallTime <= 0.0f) {

				//projektil erzeugen
				GameObject projectileInstance = Instantiate (projectilePrefab);
				TestProjectile projScript = projectileInstance.GetComponent<TestProjectile> ();
				projScript.setup (transform.position, vecToEnemy);

				//wartezeit (intervall) bis zum nächst möglichen angriff
				actualIntervallTime = fireIntervall;
			}
		}
				
	}


}

