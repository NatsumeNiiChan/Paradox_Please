using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMovement : MonoBehaviour
{
    public DayNight TimeScript;

    public GameObject GuardOne;
    public GameObject GuardTwo;
    public GameObject GuardThree;
    public GameObject NPCOne;
    public GameObject NPCTwo;
    public GameObject Door;

    private void Update()
    {
        if (TimeScript.Hours == 9)
        {
            GuardOne.transform.position = new Vector3(-3, 18, 0);
        }

        if (TimeScript.Hours == 18)
        {
            GuardOne.transform.position = new Vector3(-13, -8, 0);
        }

        if (TimeScript.Hours == 17)
        {
            GuardTwo.transform.position = new Vector3(3, 18, 0);
        }

        if (TimeScript.Hours == 2)
        {
            GuardTwo.transform.position = new Vector3(100, -100, 0);
        }

        if (TimeScript.Hours == 1)
        {
            GuardThree.transform.position = new Vector3(-5, 18, 0);
        }

        if (TimeScript.Hours == 10)
        {
            GuardThree.transform.position = new Vector3(-97, -95, 0);
        }
    }
}
