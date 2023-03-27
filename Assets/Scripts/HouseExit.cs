using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseExit : MonoBehaviour
{
    public GameObject Player;

    public GameObject Garden;
    public GameObject Exit;

    public bool Collision = false;

    private void Awake()
    {
        Player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Collision == true)
        {
            Player.transform.position = Garden.transform.position;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Exit.SetActive(true);

        Collision = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Exit.SetActive(false);

        Collision = false;
    }
}
