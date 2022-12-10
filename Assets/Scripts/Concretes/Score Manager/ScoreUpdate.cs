using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    private int _score;
    public int Score 
    { 
        get { return _score; }
        set {;}
    }
    [SerializeField] private TextMeshProUGUI _scoreTxt;

    private void Awake()
    {
        _score = 0;
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _scoreTxt.text = "" + (int)_score;
            _score ++;
        }
    }
}