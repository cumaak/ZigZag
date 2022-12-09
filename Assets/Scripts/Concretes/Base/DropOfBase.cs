using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOfBase : Dropping
{
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            StartCoroutine(Drop(this.gameObject));
        }
    }
}
