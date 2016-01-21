using UnityEngine;
using System.Collections;

public class FireAlgo_Straight : MonoBehaviour {

	Transform thistransform;
	//verwendetes Projektil
	GameObject projectilePrefab;
	TestProjectile_Logic projectile_Logic;
	float fireIntervall;
	float range;
	float actualIntervallTime;
	//sagt, ob der Turm schon oder noch ein Ziel hat
	bool hasTarget;
	Collider2D targetEnemy;

	//wird ausgeführt, wenn eine Instanz geladen wird
	void Awake(){
		actualIntervallTime = 0.0f;
		hasTarget = false;
	}

	// Use this for initialization
	void Start () {
		thistransform = gameObject.transform;
		Tower_Logic t = gameObject.GetComponent<Tower_Logic> ();
		projectilePrefab = t.getUsedProjectile ();
		projectile_Logic = projectilePrefab.GetComponent<TestProjectile_Logic>();

		fireIntervall = t.getFireIntervall ();

		range = t.getRange ();

	}
	
	// Update is called once per frame
	void Update () {

		actualIntervallTime = actualIntervallTime - Time.deltaTime;

		//schauen, ob das Ziel noch in Reichweite ist oder gelöscht wurde
		if(hasTarget){
			//Debug.Log ("fire.update ziel noch in reichweite? ausgeführt");
			if (targetEnemy == null) {
				hasTarget = false;
			} else {
				float distanceToTarget = Vector3.Distance(transform.position, targetEnemy.transform.position);
				if(distanceToTarget > range){
					hasTarget = false; 
					//targetEnemy = null;
				}
			}
		}
			
		//sucht nur Ziele, wenn es kein akutelles Ziel gibt.
		if (!hasTarget) {
			//Debug.Log ("fire.update suche ziele ausgeführt");
			Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, range);
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

		//immer ausführen
		if (hasTarget) {
			//Debug.Log ("fire.update wenn ziel da, handeln ausgeführt");
			Vector3 vecToEnemy = targetEnemy.transform.position - thistransform.position;

			//evtl. vorhalten: bewegungsgeschw. * flugzeit des projektils + position gegner

			//Geschütz etc ausrichten, Vektor: gegner - eigene pos
			//if has rotatable base...

			//feuern
			if (actualIntervallTime <= 0.0f) {
				
				//projektil erzeugen
				GameObject projectileInstance = Instantiate (projectilePrefab);
				TestProjectile_Logic pI_Logic = projectileInstance.GetComponent<TestProjectile_Logic> ();
				pI_Logic.setup(transform.position, vecToEnemy);

				//wartezeit (intervall) bis zum nächst möglichen angriff
				actualIntervallTime = fireIntervall;
			}

			/*
				Enemy_Dragon script = c.GetComponent<Enemy_Dragon> ();
				if(script != null){
					script.health -= 1;
					if(script.health <= 0){
						script.onDeath ();
					}
			    }
			    */

		}
			
	
	}

}
