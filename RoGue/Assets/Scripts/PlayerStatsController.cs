using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    //stores all necessary data about the player
    //public for now
    public int hp; //health points
    public float speed; //movement speed
    public int money; //amount of money 

    // Start is called before the first frame update
    void Start()
    {
        //init data
        hp = 100;
        speed = 5.0f;
        money = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if hp is below zero, die
        if(hp < 1)
        {
            die();
        }
    }

    void die()
    {
        //stop animating and lose player controls
        //and display an offensive message

    }
}
