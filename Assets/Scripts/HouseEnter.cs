using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseEnter : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.transform.position = new Vector3(0, 0, 0);
    }
}
