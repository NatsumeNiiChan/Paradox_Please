using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TalkingNPC : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject TextField;

    public string[] Texts;

    public string texts;

    int count = 0;

    private void Awake()
    {
        Texts = new string[]
        {
            "Hello",
            "Nice Weather!",
            "Blub"
        };
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && count < Texts.Length)
        {
            count++;
        }

        texts = Texts[count];
        GetText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TextBox.SetActive(true);
        TextField.SetActive(true);

        count = 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TextBox.SetActive(false);
        TextField.SetActive(false);
    }

    private void GetText()
    {
        if (TextBox != null)
        {
            TextBox.GetComponent<TMP_Text>().text = texts;
        }
    }
}
