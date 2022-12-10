using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOfPlatform : Dropping
{
    PlatformSpawner _platformSpawner;

    private void Awake()
    {
        _platformSpawner = GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            StartCoroutine(Drop(this.gameObject));
            StartCoroutine(Reposition(this.gameObject));
        }
    }
    IEnumerator Reposition(GameObject Platform)
    {
        yield return new WaitForSeconds(2.0f);
        _platformSpawner.Position(this.gameObject);
    }

}
