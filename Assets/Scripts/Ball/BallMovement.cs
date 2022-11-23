using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZigZag.InputController;

public class BallMovement : MonoBehaviour
{
    InputController _inputController;
    [SerializeField] float _ballSpeed;
    void Start()
    {
        _inputController = GetComponent<InputController>();
        _ballSpeed = 4.0f;
    }


    private void FixedUpdate()
    {
        transform.position += _inputController._direction * _ballSpeed * Time.deltaTime;
    }
}
