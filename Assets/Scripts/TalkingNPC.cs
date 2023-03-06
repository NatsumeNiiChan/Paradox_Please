using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkingNPC : MonoBehaviour
{
    public GameObject TextBox;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TextBox.SetActive(true);
    }

    public void GetText()
    {

    }
}
