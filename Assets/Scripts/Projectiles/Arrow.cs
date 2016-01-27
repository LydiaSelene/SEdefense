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
		if (other.gameObject.tag == "FlyingEnemy"){
			Destroy (gameObject);

			other.gameObject.SendMessage ("dealDamage", damage, SendMessageOptions.RequireReceiver);
			//coll.gameObject.SendMessage("ApplyDamage", 10);
		}

	}

	public void setTarget(Collider2D targetEnemy){
		target = targetEnemy;
		calcDirection ();
	}

	void calcDirection(){
		direction = target.transform.position - transform.position;

		//vorhalten
		Vector3 calculatedTargetPoint;
		Enemy_Dragon es = target.gameObject.GetComponent<Enemy_Dragon> ();
		float targetSpeed = es.getMovingSpeed ();
		Vector3 targetDirection = es.getMovingDirection ();
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
