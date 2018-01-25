using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_script : Bullet {


    [SerializeField]
    Rigidbody2D bullet;
    [SerializeField]
    float m_BulletSpeed;
    [SerializeField]
    float m_FiringSpeed = 0.2f;

    [SerializeField]
    private int DownSpeed;

    Random Random_generator = new Random();

    Vector3 Att_loc;
    Vector3 enemy_attackangle;
    Vector3 Direction;
    Vector2 down;
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
        down.y = -1;
    }

    // Update is called once per frame
    void Update()
    {
        Find_Target();
        Bullet_Speed();
        BulletFiringSpeed();
       

        if (Target != null)
        {
            timerl += Time.deltaTime;
            if (timerl >= 0.1f)
            {
                Att_loc.y = 6f;
                Att_loc.x = Random.Range(-14f, 14f);
                Rigidbody2D top_to_down = Instantiate(bullet, Att_loc, transform.rotation);
                top_to_down.AddForce(down * DownSpeed);
                timerl = 0;
            }
           
        }
    }

}
