using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game_Script : MonoBehaviour
{
    [SerializeField]
    

    
	void Start ()
    {
       
    }
	
	
	void Update ()
    {
        SceneManager.LoadScene(1);
    }
}
