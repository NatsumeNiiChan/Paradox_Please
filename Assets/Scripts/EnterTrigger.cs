using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTrigger : MonoBehaviour
{
    public Commandobox CommandScript;


    private void Awake()
    {
        CommandScript = GetComponent<Commandobox>();

        CommandScript.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CommandScript.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        CommandScript.enabled = false;
    }
}
