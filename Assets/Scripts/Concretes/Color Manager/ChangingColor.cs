using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    ScoreUpdate _scoreUpdate;
    private int _colorChangeScore;
    private int _auditScore = 0;

    [SerializeField] private Material _platformMaterial;
    [SerializeField] private Color[] _colors;
    [SerializeField] private float _lerpValue;
    private int _colorIndex;
    private void Awake()
    {
        _scoreUpdate = GameObject.Find("ScoreManager").GetComponent<ScoreUpdate>();
    }
    private void Update()
    {
        ChangeColor();
        _colorChangeScore = _scoreUpdate.Score + _auditScore;

         if (_colorChangeScore >= 50)
         {
            _colorIndex = Random.Range(1, 8);
            ChangeColor();
            _auditScore -=50;
         }
    }
    private void ChangeColor()
    {
        _platformMaterial.color = Color.Lerp(_platformMaterial.color, _colors[_colorIndex], _lerpValue * Time.deltaTime);
    }

    private void OnDestroy()
    {
        _platformMaterial.color = _colors[0];
    }
}
