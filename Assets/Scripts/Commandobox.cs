using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Commandobox : MonoBehaviour
{
    public GameObject Textbox;
    public TMP_InputField CommandText;

    private string CommandDoor = "Set Door to Time 15:00";

    private void Awake()
    {
        Textbox = GameObject.Find("CommandoBox");
        CommandText = GameObject.Find("InputFieldCommand").GetComponent<TMP_InputField>();


        Textbox.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Textbox.SetActive(true);
        }

        if (Textbox == true && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(CommandText.text);
            Debug.Log(CommandDoor);

            if (CheckText(CommandText.text))
            {
                Debug.Log("wright");

                Textbox.SetActive(false);
            }

            Debug.Log(CheckText(CommandText.text));
            //Textbox.SetActive(false);
        }
    }

    private bool CheckText(string text)
    {
        return string.Equals(CommandText.text, "Set Door to Time 15:00");
    }
}
