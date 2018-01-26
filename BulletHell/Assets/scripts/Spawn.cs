using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //player
    [SerializeField]
    public GameObject player;

    //fire - forest enemies
    [SerializeField]
    public GameObject enemy_lv1;
    [SerializeField]
    public GameObject enemy_lv2;
    [SerializeField]
    public GameObject enemy_lv3;
    [SerializeField]
    public GameObject minion;

    //water - beach enemies
    [SerializeField]
    public GameObject W_enemy_lv1;
    [SerializeField]
    public GameObject W_enemy_lv2;
    [SerializeField]
    public GameObject W_enemy_lv3;
    [SerializeField]
    public GameObject W_minion;

    //darknes - heaven enemies
    [SerializeField]
    public GameObject D_enemy_lv1left;
    [SerializeField]
    public GameObject D_enemy_lv1right;
    [SerializeField]
    public GameObject D_enemy_lv2;
    [SerializeField]
    public GameObject D_enemy_lv3;
    [SerializeField]
    public GameObject D_minion;
    [SerializeField]
    public GameObject D_minion_2;

    //Bosses
    [SerializeField]
    public GameObject Boss_Fire;
    [SerializeField]
    public GameObject Boss_Water;
    [SerializeField]
    public GameObject Boss_Darkness;

    // background scenes
    [SerializeField]
    public GameObject grasslands;
    [SerializeField]
    public GameObject Beach;
    [SerializeField]
    public GameObject Shrine;
    
    GameObject[] store_Enemy = new GameObject[20];
    GameObject Player;
    Vector3 pos;
    Vector3 loc = new Vector3(0, 0, 1);
    Vector3 Offscreen_Storage = new Vector3(90, 90, 90);
    Random Randomizer = new Random();

    float preparing_time;
    float Time_of_wave;
    int amount_of_enemies;
    int wave_amount = 0;//weer op null zetten dadelijk
    int Theme_amount = 0;// weer op null zetten dadelijk

    float[] location = new float[20];
    bool wave_start = true;


    // Use this for initialization
    void Start()
    {
        pos.y = -7;
        player = Instantiate(player, pos, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Theme_amount);
        preparing_time += Time.deltaTime;

        if (preparing_time >= 0.5f)
        {

            Time_of_wave += Time.deltaTime;
            //////////////////////////////////////////////////////FOREST//////////////////////////////////////////////////////////FOREST///////////
            if (Theme_amount == 0) //grasslands
            {
                grasslands.transform.position = loc;
                if (wave_amount >= 0 && wave_start == true && wave_amount <= 1)//lvl-1 fire
                {
                    pos.y = 7;
                    pos.x = -8;
                    store_Enemy[0] = Instantiate(enemy_lv1, pos, transform.rotation) as GameObject;
                }
                if (wave_amount == 1 && wave_start == true)//lvl-2 fire
                {
                    pos.y = 7;
                    pos.x = -4;
                    store_Enemy[1] = Instantiate(enemy_lv2, pos, transform.rotation) as GameObject;
                }
                if (wave_amount >= 2 && wave_start == true)//mini boss fire
                {
                    pos.y = 7;
                    pos.x = 4;
                    store_Enemy[2] = Instantiate(enemy_lv3, pos, transform.rotation) as GameObject;
                }
                if (wave_amount >= 3 && wave_start == true)//minion fire
                {
                    pos.y = 7;
                    pos.x = 8;
                    store_Enemy[3] = Instantiate(minion, pos, transform.rotation) as GameObject;
                }
                wave_start = false;
                if (Time_of_wave >= 20f)
                {
                    for (int i = 0; i < store_Enemy.Length; i++)
                    {
                        if (store_Enemy[i] != null)
                        {
                            Destroy(store_Enemy[i].gameObject);
                        }
                    }
                 
                    wave_start = true;
                    wave_amount += 1;
                    Time_of_wave = 0;
                }
                if (wave_amount >= 4)
                {
                    Theme_amount += 1;
                    wave_amount = 0;
                }

            }
            /////////////////////////////////////////////BEACH////////////////////////////////////////////BEACH///////////////////////////////////
            else if (Theme_amount == 1) //beach
            {

                grasslands.transform.position = Offscreen_Storage;
                Beach.transform.position = loc;
                if (wave_amount >= 0 && wave_start == true && wave_amount <= 1)//lvl-1 water
                {
                    pos.y = 0;
                    pos.x = 0;
                    store_Enemy[0] = Instantiate(W_enemy_lv1, pos, transform.rotation) as GameObject;
                }
                if (wave_amount == 1 && wave_start == true)//lvl-2 water
                {
                    pos.y = -7;
                    pos.x = -13;
                    store_Enemy[1] = Instantiate(W_enemy_lv2, pos, transform.rotation) as GameObject;
                }
                if (wave_amount >= 2 && wave_start == true)//mini boss water
                {
                    pos.y = 3;
                    pos.x = 0;
                    store_Enemy[2] = Instantiate(W_enemy_lv3, pos, transform.rotation) as GameObject;
                }
                if (wave_amount >= 3 && wave_start == true)//minion water
                {
                    pos.y = 5;
                    pos.x = 3;
                    store_Enemy[3] = Instantiate(W_minion, pos, transform.rotation) as GameObject;
                }
                wave_start = false;
                if (Time_of_wave >= 20f)
                {
                    for (int i = 0; i < store_Enemy.Length; i++)
                    {
                        if (store_Enemy[i] != null)
                        {
                            Destroy(store_Enemy[i].gameObject);
                        }

                    }
                  
                    wave_start = true;
                    wave_amount += 1;
                    Time_of_wave = 0;
                }
                if (wave_amount >= 4)
                {
                    Theme_amount += 1;
                    wave_amount = 0;
                }



            }
            ///////////////////////////////////////////////////HEAVEN//////////////////////////////////////////////////////HEAVEN//////////////////
            else if (Theme_amount == 2) //heaven
            {

                Beach.transform.position = Offscreen_Storage;
                Shrine.transform.position = loc;
                if (wave_amount >= 0 && wave_start == true && wave_amount <= 0)//lvl-1 heaven
                {
                    pos.y = 4;
                    pos.x = -13;
                    store_Enemy[0] = Instantiate(D_enemy_lv1left, pos, transform.rotation) as GameObject;
                    pos.y = -4;
                    pos.x = 13;
                    store_Enemy[4] = Instantiate(D_enemy_lv1left, pos, transform.rotation) as GameObject;
                }
                if (wave_amount == 1 && wave_start == true)//lvl-2 heaven
                {
                    pos.y = 7;
                    pos.x = -13;
                    store_Enemy[1] = Instantiate(D_enemy_lv2, pos, transform.rotation) as GameObject;
                    pos.y = -7;
                    pos.x = 13;
                    store_Enemy[5]=Instantiate(D_enemy_lv2, pos, transform.rotation) as GameObject;
                }
                if (wave_amount >= 2 && wave_start == true)//mini boss heaven
                {
                    pos.y = 0;
                    pos.x = 0;
                    store_Enemy[2] = Instantiate(D_enemy_lv3, pos, transform.rotation) as GameObject;
                }
                if (wave_amount >= 3 && wave_start == true)//minion heaven
                {
                    pos.y = 0;
                    pos.x = -13;
                    store_Enemy[3] = Instantiate(D_minion, pos, transform.rotation) as GameObject;

                    pos.y = 0;
                    pos.x = 15;
                    store_Enemy[4] = Instantiate(D_minion_2, pos, transform.rotation) as GameObject;
                }
                wave_start = false;
                if (Time_of_wave >= 20f)
                {
                    for (int i = 0; i < store_Enemy.Length; i++)
                    {
                        if (store_Enemy[i] != null)
                        {
                            Destroy(store_Enemy[i].gameObject);
                        }
                    }

                    wave_start = true;
                    wave_amount += 1;
                    Time_of_wave = 0;
                }
                if (wave_amount >= 4)
                {
                    wave_amount = 0;
                    Theme_amount += 1;
                }
                /////////////////////////////////////////BOSSES///////////////////////////////////////////////////////BOSSES////////////////////////
                
            }
            else if (Theme_amount == 3) //BOSSES
            {

                Shrine.transform.position = Offscreen_Storage;
                grasslands.transform.position = loc;
                Debug.Log(Theme_amount);
                if (wave_amount >= 0 && wave_start == true && wave_amount <= 1)//FIRE
                {
                    pos.y = 0;
                    pos.x = 0;
                    store_Enemy[0] = Instantiate(Boss_Fire, pos, transform.rotation) as GameObject;
                    Debug.Log("boss fire check");
                }

                wave_start = false;
                if (Time_of_wave >= 20f)
                {
                    for (int i = 0; i < store_Enemy.Length; i++)
                    {
                        if (store_Enemy[i] != null)
                        {
                            Destroy(store_Enemy[i].gameObject);
                        }
                    }

                    wave_start = true;
                    wave_amount += 1;
                    Time_of_wave = 0;
                }
                if (wave_amount >= 1)
                {
                    wave_amount = 0;
                    Theme_amount += 1;
                }



            }
            else if (Theme_amount == 4) //BOSSES
            {
                grasslands.transform.position = Offscreen_Storage;
                Beach.transform.position = loc;
                Debug.Log(Theme_amount);
                if (wave_amount >= 0 && wave_start == true && wave_amount <= 1)//WATER
                {
                    pos.y = 0;
                    pos.x = 0;
                    store_Enemy[0] = Instantiate(Boss_Water, pos, transform.rotation) as GameObject;
                    Debug.Log("boss water check");
                }

                wave_start = false;
                if (Time_of_wave >= 20f)
                {
                    for (int i = 0; i < store_Enemy.Length; i++)
                    {
                        if (store_Enemy[i] != null)
                        {
                            Destroy(store_Enemy[i].gameObject);
                        }
                    }

                    wave_start = true;
                    wave_amount += 1;
                    Time_of_wave = 0;
                }
                if (wave_amount >= 1)
                {
                    wave_amount = 0;
                    Theme_amount += 1;
                }
            }
            else if (Theme_amount == 5) //BOSSES
            {
                Beach.transform.position = Offscreen_Storage;
                Shrine.transform.position = loc;
                Debug.Log(Theme_amount);
                if (wave_amount >= 0 && wave_start == true && wave_amount <= 1)//DARKNESS
                {
                    pos.y = 0;
                    pos.x = 0;
                    store_Enemy[0] = Instantiate(Boss_Darkness, pos, transform.rotation) as GameObject;
                    Debug.Log("boss darknes check");
                }

                wave_start = false;
                if (Time_of_wave >= 20f)
                {
                    for (int i = 0; i < store_Enemy.Length; i++)
                    {
                        if (store_Enemy[i] != null)
                        {
                            Destroy(store_Enemy[i].gameObject);
                        }
                    }

                    wave_start = true;
                    wave_amount += 1;
                    Time_of_wave = 0;
                }
                if (wave_amount >= 1)
                {
                    wave_amount = 0;
                    Theme_amount =0;
                }
            }
        }






    }
}
