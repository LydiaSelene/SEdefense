using UnityEngine;
using System.Collections;

public class Bombscript : MonoBehaviour {

    ParticleSystem explosion;

    Vector3 direction;
    Vector3 spawnPosition;
    Collider2D target;
    float speed;
    float damage;
    bool kill;
    float explosionradius;
    float killtimer;

	// Use this for initialization
	void Start () {
        speed = 20.0f;
        killtimer = 0;
        explosion = gameObject.GetComponent<ParticleSystem>();
        explosion.Stop();
        damage = 4.0f;
        spawnPosition = transform.position;
        kill = false;
        explosionradius = 5.0f;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!kill)
        {

            if (other.gameObject.tag.Equals("FlyingEnemy") || other.gameObject.tag.Equals("GroundEnemy"))
            {
                Debug.Log("BOOM");
                Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explosionradius);
                foreach (Collider2D c in colliders)
                {
                    if (c.tag.Equals("FlyingEnemy")||c.tag.Equals("GroundEnemy"))
                   { 
                        c.gameObject.SendMessage("dealDamage", damage, SendMessageOptions.RequireReceiver);
                    }
                }
                explosion.Play();
                kill = true;
            }
            
        }
    }

    public void setTarget(Collider2D targetEnemy)
    {
        target = targetEnemy;
        calcDirection();
    }

    void calcDirection()
    {
        direction = target.transform.position - transform.position;

        //vorhalten bei bewegten Zielen
        Vector3 calculatedTargetPoint;

        float targetSpeed = 0;
        Vector3 targetDirection = Vector3.zero;
        if (target.name.Contains("Enemy_Dragon"))
        {
            Enemy_Dragon es = target.gameObject.GetComponent<Enemy_Dragon>();
            targetSpeed = es.getMovingSpeed();
            targetDirection = es.getMovingDirection();
        }

        calculatedTargetPoint = targetDirection.normalized * (targetSpeed * (direction.magnitude / speed));
        direction = direction + calculatedTargetPoint;
    }

	// Update is called once per frame
	void Update () {
        if (kill)
        {
            if (killtimer > 0.2)
            {
                Destroy(gameObject);
            }
            else
            {
                killtimer += Time.deltaTime;
                explosion.Play();
            }
        }
        if (Vector3.Distance(transform.position, spawnPosition) > 20f || target == null)
        {
            kill = true;
            killtimer = 0.2f;
        }
        else
        {
            calcDirection();
        }

        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);	
	}
}
