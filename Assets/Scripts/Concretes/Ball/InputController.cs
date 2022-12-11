using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZigZag.InputController
{
    public class InputController : MonoBehaviour
    {
        public Vector3 Direction { get; private set; }
        void Start()
        {
            Direction = Vector3.forward;
        }

        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                if(Direction.x == 0f)
                {
                    Direction = Vector3.left;
                }
                else
                {
                    Direction = Vector3.forward;
                }
            }
        }
    }
}

