using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletion : MonoBehaviour {

    float Timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;

        if (Timer >= 3)
        {
            Destroy(gameObject);
        }
        
	}

    

}
