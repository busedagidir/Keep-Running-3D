using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    [SerializeField] private Text _endScoreText;

    void Start()
    {
        _endScoreText.text = PlayerPrefs.GetFloat("Score", 0).ToString("0"); 
    }

}
