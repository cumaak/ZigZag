using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositioningOfPlatform : Positioning
{
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            StartCoroutine(Reposition());
        }
    }
    IEnumerator Reposition()
    {
        yield return new WaitForSeconds(1.5f);
        Position(this.gameObject);
    }
}
