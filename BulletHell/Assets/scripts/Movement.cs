using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    Vector3 mouseposition;
    Vector3 direction;
    Vector3 Pos_mouse;

    float timerl;

    [SerializeField]
    private Transform target;

    Vector3 Direction;
    int health = 999;
    [SerializeField]
    Rigidbody2D bullet;

	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {

        timerl += Time.deltaTime;

        direction = transform.position;
        direction.y += 1;
        Pos_mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Pos_mouse.z = 0;

        if (target != null)
        {
            Direction = (target.position - transform.position).normalized;
        }

        mouseposition = transform.position;
        mouseposition.y += 1;
        transform.position = Pos_mouse;

        //if(Input.GetMouseButton(0))
        //{
        //    if (timerl >= 0.2f)
        //    {
        //        if (bullet != null)
        //        {
        //            Rigidbody2D newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;

        //            newProjectile.AddForce(Direction * 1000);
        //        }
        //        timerl = 0;
        //    }
        //}

	}


    public void OnCollisionEnter2D(Collision2D collision)///player death by bullets
    {
        if (collision.collider.tag == "Enemy_Bullet")
        {

            health -= 1;
            if (health <= 0)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene(2);
            }

        }
    }
}
