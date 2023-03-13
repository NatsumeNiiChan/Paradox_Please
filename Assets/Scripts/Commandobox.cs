using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commandobox : MonoBehaviour
{
    public GameObject Textbox;
    public GameObject Commando;

    private void Awake()
    {
        Textbox = GameObject.Find("Commandobox");
        Commando = GameObject.Find("CommandoText");

        Textbox.SetActive(false);
        Commando.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Textbox.SetActive(true);
            Commando.SetActive(true);
        }
    }
}
