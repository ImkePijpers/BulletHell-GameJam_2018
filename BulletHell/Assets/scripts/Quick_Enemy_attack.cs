using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quick_Enemy_attack : Bullet
{

    
    public GameObject target;
    Transform target_loc;

    [SerializeField]
    Rigidbody2D bullet;

    [SerializeField]
    float m_BulletSpeed;
    [SerializeField]
    float m_FiringSpeed = 0.2f;

    float timerl;
    float m_Speed;
    float firingspeed;

    Vector3 Direction;

    public override void Find_Target()
    {
        Target = GameObject.FindWithTag("Player");
        Debug.Log(Target);
    }

    public override void Bullet_Speed()
    {
        m_Speed = m_BulletSpeed;
    }
    public override void BulletFiringSpeed()
    {
        firingspeed = m_FiringSpeed;
    }

    // Update is called once per frame
    void Update () {
        Find_Target();
        Bullet_Speed();
        BulletFiringSpeed();

        //target = GameObject.FindWithTag("Player");

<<<<<<< HEAD
       // Debug.Log(target);
       // Debug.Log(Direction);
        if (Target != null)
=======
        //Debug.Log(target);
        //Debug.Log(Direction);
        if (target != null)
>>>>>>> d4a22550c60bebcd04332dc24a66cae6a0b96daa
        {

            //target_loc.position = target.transform.position;
            Direction = (Target.transform.position - transform.position).normalized;

            timerl += Time.deltaTime;

            if (timerl >= firingspeed)
            {

<<<<<<< HEAD
                Rigidbody newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                newProjectile.AddForce(Direction * m_BulletSpeed);
=======
                Rigidbody2D newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                newProjectile.AddForce(Direction * Bulletspeed);
>>>>>>> d4a22550c60bebcd04332dc24a66cae6a0b96daa
                timerl = 0;
            }
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player_Bullet")
        {
            Destroy(this.gameObject);
        }
    }

}
