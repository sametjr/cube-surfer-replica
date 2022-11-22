using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField] private GameObject winPopUp, losePopUp;
    public void LevelFailed()
    {
        losePopUp.SetActive(true);
        Time.timeScale = 0;
    }

    public void LevelPassed()
    {
        winPopUp.SetActive(true);
        Time.timeScale = 0;
    }
}
