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

    Quaternion to_player;
    Vector3 enemy_attackangle;
    public GameObject target;
    Transform target_loc;
    float timerl;
    float timetotime = 25;
    float timer_180attack;
    float m_Speed;
    float firingspeed;
    Vector3 Direction;
    float wizardshootfaster = 800;

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
            wizardshootfaster += Time.deltaTime;

            timer_180attack += Time.deltaTime;

            for (int i = 0; i < wizardshootfaster; i++)
            {
                if (timerl >= m_FiringSpeed)
                {

                    Rigidbody2D newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                    newProjectile.AddForce(Direction *( m_BulletSpeed +(m_BulletSpeed*i)));
                    wizardshootfaster += 1;
                    timerl = 0;
                    
                }
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
