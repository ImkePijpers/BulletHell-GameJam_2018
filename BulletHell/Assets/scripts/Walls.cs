using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walls : MonoBehaviour {

	

    private void OnCollisionEnter2D(Collision2D collision)//out of screen collison and player deadth trigger 
    {
        Destroy(collision.gameObject);
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Death By Wall");
            SceneManager.LoadScene(2);
        }
            
    }
    
    
}
