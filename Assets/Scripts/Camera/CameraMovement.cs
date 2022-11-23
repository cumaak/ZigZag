using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;
    private Vector3 _offset;
    [SerializeField] [Range (0,3)] private float _lerpValue;
    void Start()
    {
        _offset = transform.position - _ballTransform.position;
    }

    private void LateUpdate()
    {
        //transform.position = Vector3.Lerp(transform.position, _ballTransform.position + _offset, _lerpValue * Time.deltaTime);
        transform.Translate(0f, 1.8f * Time.deltaTime, 1.8f * Time.deltaTime);
    }
}
