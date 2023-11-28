using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTFlavienScript : MonoBehaviour
{

    public GameObject equipe1;
    private bool stopTest;

    void Update()
    {
  
        if (Input.GetKey(KeyCode.A) && !stopTest)
        {
            stopTest = true;
            equipe1.SetActive(true);
            StartCoroutine(Cooldown());
        }
        
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(5f);
        stopTest = false;
        equipe1.SetActive(false);
    }

}
