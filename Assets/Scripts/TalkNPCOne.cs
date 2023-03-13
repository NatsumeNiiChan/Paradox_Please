using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;

public class TalkNPCOne : MonoBehaviour
{
    public GameObject TextboxOne;
    public GameObject Textfield;

    [SerializeField]
    private LocalizedString localizedString;


    private void Awake()
    {
        TextboxOne = GameObject.Find("TextNPCOne");
        Textfield = GameObject.Find("Textbox");

        TextboxOne.SetActive(false);
        Textfield.SetActive(false);
    }

    private void Start()
    {
        string key = "Text 1";
        //localizedString.TableEntryReference = new TableEntryReference(key);
        string value = localizedString.GetLocalizedString();

        Debug.Log("Localized Value:" + value);
    }
}
