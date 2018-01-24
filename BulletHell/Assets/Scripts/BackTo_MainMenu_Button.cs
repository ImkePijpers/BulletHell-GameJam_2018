using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackTo_MainMenu_Button : MonoBehaviour {

    [SerializeField]
    private Button Back_Button;
    

    void Update()
    {
        Back_Button.onClick.AddListener(Load_scene);


    }

    public void Load_scene()
    {
        SceneManager.LoadScene(0);
    }
}
