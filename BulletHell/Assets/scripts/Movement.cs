using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Vector3 mouseposition;
    Vector3 direction;
    Vector3 Pos_mouse;

    float timerl;

    [SerializeField]
    private Transform target;

    [SerializeField]
    Rigidbody bullet;

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


        Vector3 Direction = (target.position - transform.position).normalized;

        mouseposition = transform.position;
        mouseposition.y += 1;
        transform.position = Pos_mouse;

        if(Input.GetMouseButton(0))
        {
            if (timerl >= 0.2f)
            {
                Rigidbody newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                newProjectile.AddForce(Direction * 1000);
                timerl = 0;
            }
        }

	}
}
