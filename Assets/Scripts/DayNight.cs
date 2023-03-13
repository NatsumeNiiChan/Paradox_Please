using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;

public class DayNight : MonoBehaviour
{
    public TextMeshProUGUI TimeDisplay;
    public TextMeshProUGUI DayDisplay;
    public Volume ppv;

    public float Tick;
    public float Seconds;
    public int Mins;
    public int Hours;
    public int Days = 1;

    public bool ActivateLights;
    public GameObject[] Lights;

    private void Start()
    {
        ppv = gameObject.GetComponent<Volume>();
    }

    private void FixedUpdate()
    {
        CalculateTime();
        DisplayTime();

    }

    public void CalculateTime()
    {
        Seconds += Time.fixedDeltaTime * Tick;

        if (Seconds >= 60)
        {
            Seconds = 0;
            Mins += 1;
        }

        if (Mins >= 60)
        {
            Mins = 0;
            Hours += 1;
        }

        if (Hours >= 24)
        {
            Hours = 0;
            Days += 1;
        }

        ControlPPV();
    }

    public void ControlPPV()
    {
        if (Hours >= 21 && Hours < 22)
        {
            ppv.weight = (float)Mins / 60;

            if (ActivateLights == false)
            {
                if (Mins > 45)
                {
                    for (int i = 0; i < Lights.Length; i++)
                    {
                        Lights[i].SetActive(true);
                    }
                    ActivateLights = true;
                }
            }
        }

        if (Hours >= 6 && Hours < 7)
        {
            ppv.weight = 1 - (float)Mins / 60;

            if (ActivateLights == true)
            {
                if (Mins > 45)
                {
                    for (int i = 0; i < Lights.Length; i++)
                    {
                        Lights[i].SetActive(false);
                    }
                    ActivateLights = false;
                }
            }
        }
    }

    public void DisplayTime()
    {
        TimeDisplay.text = string.Format("{0:00}:{1:00}", Hours, Mins);
        DayDisplay.text = "Day: " + Days;
    }
}
