using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart_Button : MonoBehaviour {

    [SerializeField]
    private Button ReStart_Button;





    void Update()
    {
        ReStart_Button.onClick.AddListener(Load_scene);


    }

    public void Load_scene()
    {
        SceneManager.LoadScene(1);
    }
}
