using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Commandobox : MonoBehaviour
{
    public GameObject Textbox;
    public TMP_InputField CommandText;
    public GameObject UIText;
    public GameObject ObjectOne;
    public GameObject ObjectTwo;
    public PlayerMovement PlayerScript;

    public string CommandObject;

    public bool InTrigger = false;

    private void Awake()
    {
        //Textbox = GameObject.Find("CommandoBox");
        //CommandText = GameObject.Find("InputFieldCommand").GetComponent<TMP_InputField>();
        //UIText = GameObject.Find("PressEnter");

        //UIText.SetActive(false);
        //Textbox.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && InTrigger == true)
        {
            Textbox.SetActive(true);

            UIText.SetActive(false);

            PlayerScript.enabled = false;
        }

        if (Textbox.activeInHierarchy && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(CommandText.text);
            Debug.Log(CommandObject);

            if (CommandText.text == CommandObject)
            {
                Debug.Log("right");

                ObjectOne.SetActive(false);
                ObjectTwo.SetActive(true);

                Textbox.SetActive(false);

                InTrigger = false;

                PlayerScript.enabled = true;
            }

            else
            {
                CommandText.text = null;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("false");

            Textbox.SetActive(false);

            InTrigger = false;

            PlayerScript.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("In Trigger");

        UIText.SetActive(true);
        
        InTrigger = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        InTrigger = false;

        UIText.SetActive(false);
    }
}
