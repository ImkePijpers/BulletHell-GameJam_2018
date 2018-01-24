using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_Game_Script : MonoBehaviour
{
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
	
	
	
	////void Update ()
 //   {
 //       Start_Button.onClick.AddListener(Load_scene);
       
        
 //   }

 //   public void Load_scene()
 //   {
 //       SceneManager.LoadScene(1);
 //   }
}
