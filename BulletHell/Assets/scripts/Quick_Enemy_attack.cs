using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quick_Enemy_attack : MonoBehaviour {

    [SerializeField]
    private Transform target;

    [SerializeField]
    Rigidbody bullet;

    float timerl;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 Direction = (target.position - transform.position).normalized;

        timerl += Time.deltaTime;

        if (timerl >= 0.2f)
        {
            Rigidbody newProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            newProjectile.AddForce(Direction * 1000);
            timerl = 0;
        }

    }
}
