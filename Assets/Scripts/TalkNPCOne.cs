using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkNPCOne : MonoBehaviour
{
    public GameObject TextboxOne;
    public GameObject Textfield;


    private void Awake()
    {
        TextboxOne = GameObject.Find("TextNPCOne");
        Textfield = GameObject.Find("Textbox");

        TextboxOne.SetActive(false);
        Textfield.SetActive(false);
    }
}
