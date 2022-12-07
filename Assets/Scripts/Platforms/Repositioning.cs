using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repositioning : MonoBehaviour
{
    PlatformSpawner _platformSpawner;

    private void Start()
    {
        _platformSpawner = GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            StartCoroutine(Falling(this.gameObject));
            StartCoroutine(Respawn(this.gameObject));
        }
    }

    IEnumerator Falling(GameObject Platform)
    {
        yield return new WaitForSeconds(0.5f);
        Platform.GetComponent<Rigidbody>().useGravity = true;
        Platform.GetComponent<Rigidbody>().isKinematic = false;
        yield return new WaitForSeconds(1.0f);
        Platform.GetComponent<Rigidbody>().useGravity = false;
        Platform.GetComponent<Rigidbody>().isKinematic = true;
    }
    IEnumerator Respawn(GameObject Platform)
    {
        yield return new WaitForSeconds(1.5f);
        _platformSpawner.SpawnPlatform(this.gameObject);
    }
}
