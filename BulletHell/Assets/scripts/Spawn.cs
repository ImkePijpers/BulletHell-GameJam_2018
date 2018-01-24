using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    [SerializeField]
    public GameObject player;

    [SerializeField]
    public GameObject enemy_lv1;
    [SerializeField]
    public GameObject enemy_lv2;
    [SerializeField]
    public GameObject enemy_lv3;
    [SerializeField]
    public GameObject minion;

    [SerializeField]
    public GameObject W_enemy_lv1;
    [SerializeField]
    public GameObject W_enemy_lv2;
    [SerializeField]
    public GameObject W_enemy_lv3;
    [SerializeField]
    public GameObject W_minion;

    [SerializeField]
    public GameObject D_enemy_lv1;
    [SerializeField]
    public GameObject D_enemy_lv2;
    [SerializeField]
    public GameObject D_enemy_lv3;
    [SerializeField]
    public GameObject D_minion;


    [SerializeField]
    public Sprite grasslands;
    [SerializeField]
    public Sprite Beach;
    [SerializeField]
    public Sprite Shrine;


    


    GameObject[] store_Enemy = new GameObject[20];
    GameObject Player;
    Vector3 pos;

    Random Randomizer = new Random();

    float Time_of_wave;
    int amount_of_enemies;
    int wave_amount;
    int Theme_amount;
    float[] location = new float[20];
    bool wave_start = true;


	// Use this for initialization
	void Start () {
        pos.y = -7;
        player = Instantiate(player, pos,transform.rotation);
        
        //pos.y = 7;
        //Instantiate(enemy_lv1, pos, transform.rotation);

        //pos.y = 7;
        //pos.x = 7;
        //Instantiate(minion, pos, transform.rotation);
	}
	
	// Update is called once per frame
	void Update ()
    {
        Time_of_wave += Time.deltaTime;

        if(Theme_amount == 0) //grasslands
        {
            if(wave_amount >= 0 && wave_start == true && wave_amount <= 1)
            {
                pos.y = 7;
                pos.x = -8;
                store_Enemy[0] = Instantiate(enemy_lv1, pos, transform.rotation) as GameObject;
            }
            if (wave_amount == 1 && wave_start == true)
            {
                pos.y = 7;
                pos.x = -4;
                store_Enemy[1] = Instantiate(enemy_lv2, pos, transform.rotation) as GameObject;
            }
            if (wave_amount >= 2 && wave_start == true)
            {
                pos.y = 7;
                pos.x = 4;
                store_Enemy[2] = Instantiate(enemy_lv3, pos, transform.rotation)as GameObject;
            }
            if (wave_amount >= 3 && wave_start == true)
            {
                pos.y = 7;
                pos.x = 8;
                store_Enemy[3] = Instantiate(minion, pos, transform.rotation)as GameObject;
            }
            wave_start = false;
            if(Time_of_wave >= 20f)
            {
                if (store_Enemy[0] != null)
                {
                    Destroy(store_Enemy[0].gameObject);
                }
                if (store_Enemy[1] != null)
                {
                    Destroy(store_Enemy[1].gameObject);
                }
                if (store_Enemy[2] != null)
                {
                    Destroy(store_Enemy[2].gameObject);
                }
                if (store_Enemy[3] != null)
                {
                    Destroy(store_Enemy[3].gameObject);
                }
                //if (player != null)
                //{
                //    Destroy(player);
                //    player = Instantiate(player, pos, transform.rotation);
                //}


                wave_start = true;
                wave_amount += 1;
                Time_of_wave = 0;
            }
            if (wave_amount >= 4)
            {
                Theme_amount += 1;
            }

        }
        else if(Theme_amount == 1) //beach
        {
            if (wave_amount >= 0 && wave_start == true)
            {
                pos.y = 7;
                pos.x = -8;
                store_Enemy[0] = Instantiate(W_enemy_lv1, pos, transform.rotation) as GameObject;
            }
            if (wave_amount >= 1 && wave_start == true)
            {
                pos.y = 7;
                pos.x = -4;
                store_Enemy[1] = Instantiate(W_enemy_lv2, pos, transform.rotation) as GameObject;
            }
            if (wave_amount >= 2 && wave_start == true)
            {
                pos.y = 7;
                pos.x = 4;
                store_Enemy[2] = Instantiate(W_enemy_lv3, pos, transform.rotation) as GameObject;
            }
            if (wave_amount >= 3 && wave_start == true)
            {
                pos.y = 7;
                pos.x = 8;
                store_Enemy[3] = Instantiate(minion, pos, transform.rotation) as GameObject;
            }
            wave_start = false;
            if (Time_of_wave >= 20f)
            {
                if (store_Enemy[0] != null)
                {
                    Destroy(store_Enemy[0].gameObject);
                }
                if (store_Enemy[1] != null)
                {
                    Destroy(store_Enemy[1].gameObject);
                }
                if (store_Enemy[2] != null)
                {
                    Destroy(store_Enemy[2].gameObject);
                }
                if (store_Enemy[3] != null)
                {
                    Destroy(store_Enemy[3].gameObject);
                }
                //if (player != null)
                //{
                //    Destroy(player);
                //    player = Instantiate(player, pos, transform.rotation);
                //}


                wave_start = true;
                wave_amount += 1;
                Time_of_wave = 0;
            }
            if (wave_amount >= 4)
            {
                Theme_amount += 1;
            }



        }
        else if (Theme_amount == 2) //shrine
        {




        }






	}
}
