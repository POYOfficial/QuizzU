using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTFlavienScript : MonoBehaviour
{

    public GameObject equipe1;
    public float vote1;
    public GameObject equipe2;
    public float vote2;
    public GameObject equipe3;
    public float vote3;
    public GameObject equipe4;
    public float vote4;
    public GameObject equipe5;
    public float vote5;
    public GameObject equipe6;
    public float vote6;
    public GameObject equipe7;
    public float vote7;
    public GameObject equipe8;
    public float vote8;
    public GameObject equipe9;
    public float vote9;
    public GameObject equipe10;
    public float vote10;
    public GameObject equipe11;
    public float vote11;
    public GameObject equipe12;
    public float vote12;
    public GameObject equipe13;
    public float vote13;
    public GameObject equipe14;
    public float vote14;
    private bool stopTest;
    public float Maxvote;
    void Update()
    {
  
        if (Input.GetKey(KeyCode.A) && !stopTest && vote1<Maxvote)
        {
            stopTest = true;
            equipe1.SetActive(true);
            StartCoroutine(Cooldown());
            vote1 = 1;

        }
        if (Input.GetKey(KeyCode.Z) && !stopTest)
        {
            stopTest = true;
            equipe2.SetActive(true);
            StartCoroutine(Cooldown());

        }

    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(5f);
        stopTest = false;
        equipe1.SetActive(false);
        equipe2.SetActive(false);
    }

}
