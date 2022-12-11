using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    public int Score { get; private set; }
    [SerializeField] private TextMeshProUGUI _scoreTxt;

    private void Awake()
    {
        Score = 0;
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _scoreTxt.text = "" + (int)Score;
            Score ++;
        }
    }
}