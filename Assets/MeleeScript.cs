using UnityEngine;
using System.Collections;

public class MeleeScript : MonoBehaviour {

    Transform thistransform;

    //Intervall in Sekunden. Wenn der Turm feuert, muss diese Zeit ablaufen, bis er erneut feuern kann.
    float fireIntervall;
    float actualIntervallTime;

    //Ziel- oder Feuerradius des Turms
    float radius;

    //Angriffspartikel
    ParticleSystem atkAnim;

    float dmg;

    // Use this for initialization
    void Start()
    {
        thistransform = gameObject.transform;

        fireIntervall = 0.6f;
        actualIntervallTime = 0.0f;
        radius = 10f;
        atkAnim = gameObject.GetComponent<ParticleSystem>();
        dmg = 10.0f;
    }


    // Update is called once per frame
    void Update()
    {

        if (actualIntervallTime > 0f)
        {
            actualIntervallTime = actualIntervallTime - Time.deltaTime;
        }

        if (actualIntervallTime <= 0.0f)
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);
            //Gegner unter den Collidern suchen
            foreach (Collider2D c in colliders)
            {
                if (c.tag.Equals("FlyingEnemy"))
                {
                    atkAnim.Play();
                    c.gameObject.SendMessage("dealDamage", dmg, SendMessageOptions.RequireReceiver);
                }
            }
            actualIntervallTime = fireIntervall;
        }

    }


}