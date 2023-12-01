using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTFlavienScript : MonoBehaviour
{
    //public GameObject[] equipe;
    public GameObject equipe1;
    private float vote1;
    public GameObject equipe2;
    private float vote2;
    public GameObject equipe3;
    private float vote3;
    public GameObject equipe4;
    private float vote4;
    public GameObject equipe5;
    private float vote5;
    public GameObject equipe6;
    private float vote6;
    public GameObject equipe7;
    private float vote7;
    public GameObject equipe8;
    private float vote8;
    public GameObject equipe9;
    private float vote9;
    public GameObject equipe10;
    private float vote10;
    public GameObject equipe11;
    private float vote11;
    public GameObject equipe12;
    private float vote12;
    public GameObject equipe13;
    private float vote13;
    public GameObject equipe14;
    private float vote14;
    private bool stopTest;
    public float Maxvote;
    void Update()
    {
  
        if (Input.GetKey(KeyCode.A) && !stopTest && vote1<Maxvote)
        {
            Reset();
            stopTest = true;
            equipe1.SetActive(true);
            StartCoroutine(Cooldown());
            vote1 = 1;


        }
        if (Input.GetKey(KeyCode.Z) && !stopTest && vote2<Maxvote)
        {
            Reset();
            stopTest = true;
            equipe2.SetActive(true);
            StartCoroutine(Cooldown());
            vote2 = 1;

        }
        if (Input.GetKey(KeyCode.E) && !stopTest && vote3 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe3.SetActive(true);
            StartCoroutine(Cooldown());
            vote3 = 1;

        }
        if (Input.GetKey(KeyCode.R) && !stopTest && vote4 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe4.SetActive(true);
            StartCoroutine(Cooldown());
            vote4 = 1;

        }
        if (Input.GetKey(KeyCode.T) && !stopTest && vote5 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe5.SetActive(true);
            StartCoroutine(Cooldown());
            vote5 = 1;

        }
        if (Input.GetKey(KeyCode.Y) && !stopTest && vote6 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe6.SetActive(true);
            StartCoroutine(Cooldown());
            vote6 = 1;


        }
        if (Input.GetKey(KeyCode.U) && !stopTest && vote7 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe7.SetActive(true);
            StartCoroutine(Cooldown());
            vote7 = 1;


        }
        if (Input.GetKey(KeyCode.I) && !stopTest && vote8 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe8.SetActive(true);
            StartCoroutine(Cooldown());
            vote8 = 1;  

        }
        if (Input.GetKey(KeyCode.O) && !stopTest && vote9 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe9.SetActive(true);
            StartCoroutine(Cooldown());
            vote9 = 1;

        }
        if (Input.GetKey(KeyCode.P) && !stopTest && vote10 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe10.SetActive(true);
            StartCoroutine(Cooldown());
            vote10 = 1; 

        }
        if (Input.GetKey(KeyCode.Q) && !stopTest && vote11 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe11.SetActive(true);
            StartCoroutine(Cooldown());
            vote11 = 1;

        }
        if (Input.GetKey(KeyCode.S) && !stopTest && vote12 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe12.SetActive(true);
            StartCoroutine(Cooldown());
            vote12 = 1; 

        }
        if (Input.GetKey(KeyCode.D) && !stopTest && vote13 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe13.SetActive(true);
            StartCoroutine(Cooldown());
            vote13 = 1;

        }
        if (Input.GetKey(KeyCode.F) && !stopTest && vote14 < Maxvote)
        {
            Reset();
            stopTest = true;
            equipe14.SetActive(true);
            StartCoroutine(Cooldown());
            vote14 = 1;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Reset();
            equipe1.SetActive(false);
            equipe2.SetActive(false);
            equipe3.SetActive(false);
            equipe4.SetActive(false);
            equipe5.SetActive(false);
            equipe6.SetActive(false);
            equipe7.SetActive(false);
            equipe8.SetActive(false);
            equipe9.SetActive(false);
            equipe10.SetActive(false);
            equipe11.SetActive(false);
            equipe12.SetActive(false);
            equipe13.SetActive(false);
            equipe14.SetActive(false);
        }


    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(5f);
        stopTest = false;
        equipe1.SetActive(false);
        equipe2.SetActive(false);
        equipe3.SetActive(false);
        equipe4.SetActive(false);
        equipe5.SetActive(false);
        equipe6.SetActive(false);
        equipe7.SetActive(false);
        equipe8.SetActive(false);
        equipe9.SetActive(false);
        equipe10.SetActive(false);
        equipe11.SetActive(false);
        equipe12.SetActive(false);
        equipe13.SetActive(false);
        equipe14.SetActive(false);
        


    }

    public void Reset()
    {
        vote1 = 0;
        vote2 = 0;
        vote3 = 0;
        vote4 = 0;
        vote5 = 0;
        vote6 = 0;
        vote7 = 0;
        vote8 = 0;
        vote9 = 0;
        vote10 = 0;
        vote11 = 0;
        vote12 = 0;
        vote13 = 0;
        vote14 = 0;
    }

}
