using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HouseEnter : MonoBehaviour
{
    public GameObject Player;

    public GameObject House;
    public GameObject Enter;

    public bool Collision = false;

    private void Awake()
    {
        Player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Collision == true)
        {
            Debug.Log("Works");

            Player.transform.position = House.transform.position;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Enter.SetActive(true);

        Collision = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Enter.SetActive(false);

        Collision = false;
    }
}
