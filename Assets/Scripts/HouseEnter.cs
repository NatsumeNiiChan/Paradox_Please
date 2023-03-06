using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseEnter : MonoBehaviour
{
    public GameObject Player;

    public GameObject House;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.transform.position = House.transform.position;
        
    }
}
