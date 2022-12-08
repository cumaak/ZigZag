using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : Positioning
{
    private List<GameObject> _platforms;
    [SerializeField] GameObject Platform;
    //[SerializeField] GameObject _firstPlatform;
    //private Vector3 _lastPosition;
    //private int _leftCount;
    //private int _forwardCount;

    private void Awake()
    {
        _platforms = new List<GameObject>();
        _lastPosition = _firstPlatform.transform.position;
        _leftCount = 0;
        _forwardCount = 0;
        CreatePlatform(_platforms);
    }
    private void Start()
    {
        for(int i=0; i<30; i++)
        {
            //SpawnPlatform(_platforms[i]);
            Position(_platforms[i]);
        }
    }

    private void CreatePlatform(List<GameObject> List)
    {
        for(int i=0; i<30; i++)
        {
            List.Add(Instantiate(Platform));
        }
    }
    /*public void SpawnPlatform(GameObject gameobject)
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
        
    }*/
}
