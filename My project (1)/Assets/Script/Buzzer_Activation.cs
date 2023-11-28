using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzzer_Activation : MonoBehaviour
{
    public GameObject buzzer;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            buzzer.SetActive(true);
        }
    }
}
