using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : Positioning
{
    private List<GameObject> _platforms;
    [SerializeField] GameObject Platform;

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
        for(int i=0; i<40; i++)
        {
            Position(_platforms[i]);
        }
    }

    private void CreatePlatform(List<GameObject> List)
    {
        for(int i=0; i<40; i++)
        {
            List.Add(Instantiate(Platform));
        }
    }
}
