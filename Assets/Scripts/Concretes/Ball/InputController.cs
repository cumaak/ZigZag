using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZigZag.InputController
{
    public class InputController : MonoBehaviour
    {
        public Vector3 _direction { get; private set; }
        void Start()
        {
            _direction = Vector3.forward;
        }

        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                if(_direction.x == 0f)
                {
                    _direction = Vector3.left;
                }
                else
                {
                    _direction = Vector3.forward;
                }
            }
        }
    }
}

