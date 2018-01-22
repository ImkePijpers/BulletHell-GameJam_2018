using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    [SerializeField]
    public GameObject player;
    [SerializeField]
    public GameObject enemy;


    Vector3 pos;

	// Use this for initialization
	void Start () {
        pos.y = -7;
        Instantiate(player, pos,transform.rotation);
        pos.y = 7;
        Instantiate(enemy, pos, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
