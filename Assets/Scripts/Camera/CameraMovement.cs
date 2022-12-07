using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.Translate(0f, 1.44f * Time.deltaTime, 1.44f * Time.deltaTime);
    }
}
