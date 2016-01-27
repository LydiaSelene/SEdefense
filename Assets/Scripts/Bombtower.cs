using UnityEngine;
using System.Collections;

public class Bombtower : MonoBehaviour
{

    Transform thistransform;

    //Intervall in Sekunden. Wenn der Turm feuert, muss diese Zeit ablaufen, bis er erneut feuern kann.
    float fireIntervall;
    float actualIntervallTime;

    //der Projektil-Typ, den dieser Turm verwendet, z.B. Kanonenkugel oder Pfeil
    public GameObject projectilePrefab;

    //Ziel- oder Feuerradius des Turms
    float radius;

    Collider2D targetEnemy;
    //sagt, ob der Turm schon oder noch ein Ziel hat
    bool hasTarget;



    // Use this for initialization
    void Start()
    {
        thistransform = gameObject.transform;

        fireIntervall = 3.0f;
        actualIntervallTime = 0.0f;
        radius = 14f;
        //radius = GetComponent<CircleCollider2D>().radius;
        hasTarget = false;

    }

    void searchTarget()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);
        //Gegner unter den Collidern suchen
        foreach (Collider2D c in colliders)
        {
			if (c.tag.Equals("FlyingEnemy")|| c.tag.Equals("GroundEnemy"))
            {
                //auf den ersten Gegner feuern
                targetEnemy = c;
                hasTarget = true;
                break;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Treffer");
    }


    // Update is called once per frame
    void Update()
    {

        if (actualIntervallTime > 0f)
        {
            actualIntervallTime = actualIntervallTime - Time.deltaTime;
        }

        //schauen, ob das Ziel noch in Reichweite ist oder gelöscht wurde
        if (hasTarget)
        {
            if (targetEnemy == null)
            {
                hasTarget = false;
            }
            else
            {
                float distanceToTarget = Vector3.Distance(transform.position, targetEnemy.transform.position);
                if (distanceToTarget > radius)
                {
                    hasTarget = false;
                    //targetEnemy = null;
                }
            }
        }

        //sucht nur Ziele, wenn es kein akutelles Ziel gibt.
        if (!hasTarget)
        {
            searchTarget();
        }

        //immer ausführen
        if (hasTarget)
        {
            //evtl. vorhalten: bewegungsgeschw. * flugzeit des projektils + position gegner

            //Geschütz etc ausrichten, Vektor: gegner - eigene pos
            //if has rotatable base...

            //feuern
            if (actualIntervallTime <= 0.0f)
            {

                //projektil erzeugen
                GameObject projectileInstance = Instantiate(projectilePrefab);
                projectileInstance.transform.position = transform.position;
                projectileInstance.SendMessage("setTarget", targetEnemy, SendMessageOptions.RequireReceiver);


                //wartezeit (intervall) bis zum nächst möglichen angriff
                actualIntervallTime = fireIntervall;
            }
        }

    }


}

