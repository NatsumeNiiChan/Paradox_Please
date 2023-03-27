using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SortingScript : MonoBehaviour
{
    public SpriteRenderer PlayerSprite;

    public int SortingOrder;


    private void Awake()
    {
        PlayerSprite = GameObject.Find("PlayerSprite").GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerSprite.sortingOrder = -1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerSprite.sortingOrder = 1;
    }
}
