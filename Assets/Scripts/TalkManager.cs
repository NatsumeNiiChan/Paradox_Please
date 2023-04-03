using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

public class TalkManager : MonoBehaviour
{
    public LocalizeStringEvent localizedStringEvent;
    private LocalizedString originalLocalizedString;

    private int i = 1;
    private string keyText;
    public int KeyCount;
    

    public LocalizedString localizedString = new LocalizedString
    { TableReference = "NPC_One", TableEntryReference = "Text 1" };
    public string TableName;
    private string KeyName;

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

            Debug.Log("Dieser Table wurde aufgerufen: " + TableName);
            Debug.Log("Dieser Key wurde aufgerufen: " + KeyName);

            i++;
        }
    }

    private void SetKeyName()
    {
        if (i <= KeyCount)
        {
            KeyName = "Text " + i;
        }

        else
        {
            i = 0;
        }
    }
}
