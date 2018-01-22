using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track_player : MonoBehaviour {

    [SerializeField]
    public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.transform.position;
	}
}
