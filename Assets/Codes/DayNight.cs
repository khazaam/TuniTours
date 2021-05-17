using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public Transform directionalLight;
    
    void Start()
    {
        DisableLights();
    }

    void Update()
    {
        directionalLight.Rotate(Time.deltaTime, 0.0f, 0.0f);
        if(directionalLight.eulerAngles.x >= 20 && directionalLight.eulerAngles.x <= 160)
        {
            DisableLights();
            DisableFog();
        }
        else
        {
            EnableLights();
            EnableFog();
        }
    }

    void EnableLights()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetChild(2).gameObject.SetActive(true);
        }
    }

    void DisableLights()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetChild(2).gameObject.SetActive(false);
        }
    }

    void EnableFog()
    {
        RenderSettings.fog = true;
    }

    void DisableFog()
    {
        RenderSettings.fog = false;
    }
}
