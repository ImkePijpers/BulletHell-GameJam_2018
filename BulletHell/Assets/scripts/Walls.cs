using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walls : MonoBehaviour {

	

    private void OnCollisionEnter2D(Collision2D collision)//out of screen collison and player deadth trigger 
    {
        
        if (collision.collider.tag == "Enemy_Bullet")
        {
            Destroy(collision.gameObject);
            //Debug.Log("Death By Wall");
            //SceneManager.LoadScene(2);
        }
            
    }
    
    
}
