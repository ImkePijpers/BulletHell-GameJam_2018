using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dark_Boss : Bullet
{




    [SerializeField]
    Rigidbody2D bullet;
    [SerializeField]
    float m_BulletSpeed;
    [SerializeField]
    float m_FiringSpeed = 0.2f;

    Vector3 enemy_attackangle;
    Vector3 Direction;
    Vector3 loc_left;
    Vector3 Loc_right;
    Vector3 down;
    float m_Speed;
    float firingspeed;
    float timerl;
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



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Find_Target();
        Bullet_Speed();
        BulletFiringSpeed();
        down.y = -1;

        if (Target != null)
        {

            //target_loc.position = target.transform.position;
            Direction = (Target.transform.position - transform.position).normalized;

            timerl += Time.deltaTime;


            if (timerl >= firingspeed)
            {
                Direction.x -= 0.4f;
                loc_left.y = 6;
                Loc_right.y = 6;
                loc_left.x = Random.Range(-12f, 20f);
                for (float i = 0; i <= 20; i += 1) //left
                {
                    
                    Rigidbody2D newProjectile = Instantiate(bullet, loc_left, transform.rotation) as Rigidbody2D;
                    Direction.x += 0.2f;
                    newProjectile.AddForce(down * m_BulletSpeed);
                    loc_left.x -= 1;
                }
                Loc_right.x = loc_left.x + 7;
                for (float i = 0; i <= 20; i += 1) //Right
                {
                    Rigidbody2D newProjectile = Instantiate(bullet, Loc_right, transform.rotation) as Rigidbody2D;
                    Direction.x += 0.2f;
                    newProjectile.AddForce(down * m_BulletSpeed);
                    Loc_right.x += 1;
                }




                timerl = 0;
            }
        }
    }
}
