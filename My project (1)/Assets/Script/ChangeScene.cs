using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int up;
    public void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene(up);
        }
    }
}
