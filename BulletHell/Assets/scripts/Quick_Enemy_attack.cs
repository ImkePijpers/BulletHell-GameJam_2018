using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quick_Enemy_attack : MonoBehaviour {

    
    public GameObject target;
    Transform target_loc;

    [SerializeField]
    Rigidbody2D bullet;

    [SerializeField]
    float Bulletspeed = 1000;
    [SerializeField]
    float firingspeed = 0.2f;

    float timerl;

    Vector3 Direction;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        target = GameObject.FindWithTag("Player");



        

        //Debug.Log(target);
        //Debug.Log(Direction);
        if (target != null)
        {

            //target_loc.position = target.transform.position;
            Direction = (target.transform.position - transform.position).normalized;

            timerl += Time.deltaTime;

            if (timerl >= firingspeed)
            {

                Rigidbody2D newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
                newProjectile.AddForce(Direction * Bulletspeed);
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
