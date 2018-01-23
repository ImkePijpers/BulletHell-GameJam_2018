using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion : Bullet
{
    //public GameObject Target;
    Transform Minion_Position;
    Vector3 Direction;
    float Timer;

    [SerializeField]
    Rigidbody Bullet;
    [SerializeField]
    float m_Bullet_Speed = 100;
    [SerializeField]
    float m_BulletFiring_Speed = 0.6f;
    public override void Find_Target()
    {
        //Target = GameObject.FindWithTag("Player");
        Debug.Log(Target);
    }

    public override void Bullet_Speed()
    {
        m_Bullet_Speed = 100;
    }
    public override void BulletFiringSpeed()
    {
        m_BulletFiring_Speed = 1;
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
        Direction = Target.transform.position;

        Debug.Log(Target);
        Debug.Log(Direction);

        


    }
}
