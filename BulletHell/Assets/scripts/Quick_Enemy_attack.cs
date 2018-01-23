using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quick_Enemy_attack : Bullet
{
    
    [SerializeField]
    Rigidbody2D bullet;
    [SerializeField]
    float m_BulletSpeed;
    [SerializeField]
    float m_FiringSpeed = 0.2f;


    Vector3 enemy_attackangle;
    public GameObject target;
    Transform target_loc;
    float timerl;
    float timer_180attack;
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
        Debug.Log(Direction);

        if (Target != null)
        {

            //target_loc.position = target.transform.position;
            Direction = (Target.transform.position - transform.position).normalized;

            timerl += Time.deltaTime;
            timer_180attack += Time.deltaTime;

            if (timerl >= firingspeed)
            {
                
                Rigidbody2D newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                newProjectile.AddForce(Direction * m_BulletSpeed);

                timerl = 0;
            }

            if (timer_180attack >= 5f)
            {
                for(float i = 0; i <= 100; i += 10)
                {
                    enemy_attackangle.y += i;
                    Rigidbody2D newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                    Direction.x += 0.3f;
                    newProjectile.AddForce(Direction * m_BulletSpeed);
                }
                timer_180attack = 0;

                Direction = (Target.transform.position - transform.position).normalized;

                for (float i = 0; i <= 100; i += 10)
                {
                    enemy_attackangle.y += i;
                    Rigidbody2D newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                    Direction.x -= 0.3f;
                    newProjectile.AddForce(Direction * m_BulletSpeed);
                }
                timer_180attack = 0;
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
