using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Bullets : MonoBehaviour {

    float Timer;
    float degrees = 10;

    [SerializeField]
    private Rigidbody2D bullet;

    Quaternion direction = new Quaternion();
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= 3)
        {
            for (int i = 0; i <= 360; i += 10)
            {

                Vector2 Rotate = Quaternion.Euler(0, 0, degrees) * transform.position;


                Rigidbody2D top_to_down = Instantiate(bullet, transform.position, transform.rotation);
                top_to_down.AddForce(Rotate * 50);
                degrees += 10;
                
            }
            Destroy(this.gameObject);
        }

    }

    


}
