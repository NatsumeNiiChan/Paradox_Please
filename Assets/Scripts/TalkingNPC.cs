using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEditor;

public class TalkingNPC : MonoBehaviour
{
    public GameObject TextBoxNPC1;
    //public GameObject TextBoxNPC2;
    //public GameObject TextBoxNPC3;
    //public GameObject TextBoxNPC4;
    public GameObject TextField;

    //public string[] Texts;

    public string texts;

    int count = 0;

    public LocalizedString myString;
    private string localizedText;

    private void Awake()
    {
        //Texts = new string[]
        //{
        //    "Hello",
        //    "Nice Weather!",
        //    "Blub"
        //};
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            count++;
            myString.TableEntryReference = localizedText;
        }

        texts = localizedText;
        GetText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TextBoxNPC1.SetActive(true);
        TextField.SetActive(true);

        count = 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TextBoxNPC1.SetActive(false);
        TextField.SetActive(false);
    }

    private void GetText()
    {
        if (TextBoxNPC1 != null)
        {
            TextBoxNPC1.GetComponent<TMP_Text>().text = texts;
        }
    }

    private void OnEnable()
    {
        myString.StringChanged += UpdateString;
    }

    private void OnDisable()
    {
        myString.StringChanged -= UpdateString;
    }

    private void UpdateString(string count)
    {
        localizedText = count;
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField(localizedText);
    }
}
