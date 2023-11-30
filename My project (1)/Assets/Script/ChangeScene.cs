using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject[] Question;
    public GameObject ProQuestions;
    private bool stopTest;
    public int QuestionNumber;

    public void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && !stopTest )
        {
            StartCoroutine(Cooldown());
            stopTest = true;
            ProQuestions.SetActive(true);
            Question[QuestionNumber].SetActive(false);
            QuestionNumber = QuestionNumber + 1;
            Question[QuestionNumber].SetActive(true);
        }
    }

    IEnumerator Cooldown()
    {
            yield return new WaitForSeconds(2f);
        ProQuestions.SetActive(false);
        stopTest = false;
            
        

    }
}
