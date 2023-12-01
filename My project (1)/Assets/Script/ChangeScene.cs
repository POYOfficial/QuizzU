using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject[] Question;
    public GameObject ProQuestions;
    public int QuestionNumber;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && ProQuestions.activeSelf == false)
        {
            ProQuestions.SetActive(true);
            Question[QuestionNumber].SetActive(false);
            QuestionNumber = QuestionNumber + 1;
            
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && ProQuestions.activeSelf == true)
        {
            ProQuestions.SetActive(false);
            Question[QuestionNumber].SetActive(true);
        }
    }

}
