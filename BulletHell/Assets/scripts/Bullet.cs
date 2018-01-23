using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject Target;
    Transform Minion_Position;
    Vector3 Direction;
    float Timer;
    float m_Bullet_Speed;
    float m_BulletFiring_Speed = 0.6f;

    [SerializeField]
    Rigidbody m_Bullet;

   


    public virtual void Find_Target()
    {
        Target = GameObject.FindWithTag("Player");
        Direction = Target.transform.position;

        Debug.Log(Target);
        Debug.Log(Direction);
    }
    public virtual void Bullet_Speed()
    {
        m_Bullet_Speed = 1;
    }
    public virtual void BulletFiringSpeed()
    {
        m_BulletFiring_Speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Find_Target();
        Bullet_Speed();
        BulletFiringSpeed();
    }
}
