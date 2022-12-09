using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Dropping : MonoBehaviour
{
    public IEnumerator Drop(GameObject Platform)
    {
        yield return new WaitForSeconds(0.5f);
        Platform.GetComponent<Rigidbody>().useGravity = true;
        Platform.GetComponent<Rigidbody>().isKinematic = false;
        yield return new WaitForSeconds(1.5f);
        Platform.GetComponent<Rigidbody>().useGravity = false;
        Platform.GetComponent<Rigidbody>().isKinematic = true;
    }
}
