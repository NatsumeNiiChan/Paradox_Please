using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

public class TalkManager : MonoBehaviour
{
    public string Name;

    public LocalizeStringEvent localizedStringEvent;
    private LocalizedString originalLocalizedString;

    private int i = 1;
    private string keyText;
    public int StringCount;

    public LocalizedString localizedString = new LocalizedString{};
    public string TableName = "NPC";
    private string KeyName;

    public GameObject TextBox;

    private void Start()
    {
        originalLocalizedString = localizedStringEvent.StringReference;

        localizedStringEvent.OnUpdateString.AddListener(OnStringChanged);
    }

    private void OnStringChanged(string s)
    {
        Debug.Log("String changed");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            localizedStringEvent.StringReference = originalLocalizedString;

            SetKeyName();

            localizedStringEvent.StringReference.SetReference(TableName, KeyName);

            i++;
        }
    }

    private void SetKeyName()
    {
        if (i <= StringCount)
        {
            KeyName = "Text " + i;
        }

        else
        {
            i = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TextBox.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TextBox.SetActive(false);
    }
}
