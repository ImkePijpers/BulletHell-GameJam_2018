using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : Bullet
{

    Transform Minion_Position;
    Vector3 Direction;
    public GameObject target;
    Transform target_loc;
    float m_Speed;
    float firingspeed = 0.6f;
    float Timer;

    [SerializeField]
    Rigidbody2D Bullet;
    [SerializeField]
    float m_Bullet_Speed;
    [SerializeField]
    float m_BulletFiring_Speed;

    public override void Find_Target()
    {
        Target = GameObject.FindWithTag("Player");
        Debug.Log(Target);
    }

    public override void Bullet_Speed()
    {
        m_Speed = m_Bullet_Speed;
    }
    public override void BulletFiringSpeed()
    {
        firingspeed = m_BulletFiring_Speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Find_Target();
        Bullet_Speed();


        Debug.Log(Target);
        Debug.Log(Direction);

        if (Target != null)
        {

            //target_loc.position = target.transform.position;
            Direction = (Target.transform.position - transform.position).normalized;

            Timer += Time.deltaTime;

            if (Timer >= m_BulletFiring_Speed)
            {

                Rigidbody2D newProjectile = Instantiate(Bullet, transform.position, transform.rotation) as Rigidbody2D;
                newProjectile.AddForce(Direction * m_Bullet_Speed);

                Timer = 0;
            }


        }
    }
}
