using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	Vector3 direction;
	Vector3 spawnPosition;
	Collider2D target;
	float speed;
	float damage;

	//wird ausgeführt, wenn eine Instanz geladen wird
	void Awake(){
		speed = 20.0f;
	}

	// Use this for initialization
	void Start () {
		damage = 6f;
		spawnPosition = transform.position;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag.Equals("FlyingEnemy") || other.gameObject.tag.Equals("GroundEnemy")){

			other.gameObject.SendMessage ("dealDamage", damage, SendMessageOptions.RequireReceiver);
			//Pfeil zerstören
			Destroy (gameObject);

		}
	}

	public void setTarget(Collider2D targetEnemy){
		target = targetEnemy;
		calcDirection ();
	}

	void calcDirection(){
		direction = target.transform.position - transform.position;

		//vorhalten bei bewegten Zielen
		Vector3 calculatedTargetPoint;

		float targetSpeed =  0;
		Vector3 targetDirection = Vector3.zero;
		if (target.name.Contains ("Enemy_Dragon")) {
			Enemy_Dragon es = target.gameObject.GetComponent<Enemy_Dragon> ();
			targetSpeed = es.getMovingSpeed ();
			targetDirection = es.getMovingDirection ();
		}else if (target.name.Contains ("Enemy_BugSoldier")) {
			Enemy_BugSoldier es = target.gameObject.GetComponent<Enemy_BugSoldier> ();
			targetSpeed = es.getMovingSpeed ();
			targetDirection = es.getMovingDirection ();
		}else if (target.name.Contains ("Enemy_Cookie1")) {
			Enemy_Cookie1 es = target.gameObject.GetComponent<Enemy_Cookie1> ();
			targetSpeed = es.getMovingSpeed ();
			targetDirection = es.getMovingDirection ();
		}else if (target.name.Contains ("Enemy_FrozenWolf")) {
			Enemy_FrozenWolf es = target.gameObject.GetComponent<Enemy_FrozenWolf> ();
			targetSpeed = es.getMovingSpeed ();
			targetDirection = es.getMovingDirection ();
		}else if (target.name.Contains ("Enemy_Goblin1")) {
			Enemy_Goblin1 es = target.gameObject.GetComponent<Enemy_Goblin1> ();
			targetSpeed = es.getMovingSpeed ();
			targetDirection = es.getMovingDirection ();
		}else if (target.name.Contains ("Enemy_Goblin2")) {
			Enemy_Goblin2 es = target.gameObject.GetComponent<Enemy_Goblin2> ();
			targetSpeed = es.getMovingSpeed ();
			targetDirection = es.getMovingDirection ();
		}else if (target.name.Contains ("Enemy_Mantis")) {
			Enemy_Mantis es = target.gameObject.GetComponent<Enemy_Mantis> ();
			targetSpeed = es.getMovingSpeed ();
			targetDirection = es.getMovingDirection ();
		}else if (target.name.Contains ("Enemy_Santa")) {
			Enemy_Santa es = target.gameObject.GetComponent<Enemy_Santa> ();
			targetSpeed = es.getMovingSpeed ();
			targetDirection = es.getMovingDirection ();
		}
			
		calculatedTargetPoint = targetDirection.normalized * (targetSpeed * (direction.magnitude / speed));
		direction = direction + calculatedTargetPoint;

		//rotation entsprechend richtungsvektor
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		//wegen der spritegrafik
		angle += 90f;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = q;

	}

	// Update is called once per frame
	void Update () {

			if (Vector3.Distance (transform.position, spawnPosition) > 20f || target == null) {
				Destroy (gameObject);
			} else {
				calcDirection ();
			}

			transform.Translate (direction.normalized*speed*Time.deltaTime, Space.World);	
	}
}
