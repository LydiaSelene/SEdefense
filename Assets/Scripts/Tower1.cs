using UnityEngine;
using System.Collections;

public class Tower1 : MonoBehaviour {

	Transform thistransform;

	// Use this for initialization
	void Start () {
		thistransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		

		Collider2D[] coll = Physics2D.OverlapCircleAll (transform.position, 3f);
		foreach (Collider2D c in coll) {
			//Debug.Log("feind");

			if(c.name.Equals("enemy")){

				CreateProjectile cp = GetComponent<CreateProjectile> ();
				cp.create ();

				Enemy1 script = c.GetComponent<Enemy1> ();
				if(script != null){
					script.health -= 1;
				if(script.health <= 0){
					script.onDeath ();
				}
				}
			}
		}
	
	}
}
