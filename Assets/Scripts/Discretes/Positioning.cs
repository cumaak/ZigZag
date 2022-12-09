using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Positioning : MonoBehaviour
{
    //[SerializeField] protected GameObject Platform;
    [SerializeField] protected GameObject _firstPlatform;
    protected Vector3 _lastPosition;
    protected int _leftCount;
    protected int _forwardCount;

    public virtual void Position(GameObject gameobject)
    {
        if (Random.Range(0, 2) == 0)
        {
            if (_leftCount < 5)
            {
                gameobject.transform.position = _lastPosition + Vector3.left;
                _lastPosition = gameobject.transform.position;
                _leftCount++;
                _forwardCount--;
            }
            else
            {
                gameobject.transform.position = _lastPosition + Vector3.forward;
                _lastPosition = gameobject.transform.position;
                _leftCount--;
                _forwardCount++;
            }
        }
        else
        {
            if (_forwardCount < 3)
            {
                gameobject.transform.position = _lastPosition + Vector3.forward;
                _lastPosition = gameobject.transform.position;
                _leftCount--;
                _forwardCount++;
            }
            else
            {
                gameobject.transform.position = _lastPosition + Vector3.left;
                _lastPosition = gameobject.transform.position;
                _leftCount++;
                _forwardCount--;
            }
        }

    }
}
