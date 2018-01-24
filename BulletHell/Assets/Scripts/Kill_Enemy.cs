using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Enemy : MonoBehaviour {

    [SerializeField]
    public GameObject Enemy_death;

    [SerializeField]
    private GameObject playerBullet;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == playerBullet.name)
        {
            Debug.Log("Should be killed");
            
                Destroy(Enemy_death);
            
            
        }
        else
        {
            Debug.Log("Is not killed");
        }
    }
}
