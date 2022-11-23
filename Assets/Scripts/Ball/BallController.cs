using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }

    }

}
