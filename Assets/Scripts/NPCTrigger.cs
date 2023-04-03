using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCTrigger : MonoBehaviour
{
    public string Name;

    public GameObject TextBox;

    public TMP_Text Text;

    public TalkManager Script;

    private void Awake()
    {
        Script = GetComponent<TalkManager>();

        Script.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TextBox.SetActive(true);
        Text.enabled = true;
        Script.enabled = true;

        Text.text = "...";
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TextBox.SetActive(false);
        Text.enabled = false;
        Script.enabled = false;
    }
}
