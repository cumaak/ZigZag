using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    ScoreUpdate _scoreUpdate;
    private int _colorChangeScore;
    private int _auditScore = 0;

    private void Awake()
    {
        _scoreUpdate = GameObject.Find("ScoreManager").GetComponent<ScoreUpdate>();
        _colorChangeScore = _scoreUpdate.Score + _auditScore;
    }
    private void Update()
    {
        if(_colorChangeScore >= 50)
        {
            //Function
            _auditScore -=50;
        }
    }
}
