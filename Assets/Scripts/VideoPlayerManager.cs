using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// will work with socket handler

/**
* Ready(Video URL)
* isReady(): bool [VideoPlayer.prepareCompleted]
* isFinished(): bool [VideoPlayer.loopPointReached]
*
*
**/
public class VideoPlayerManager : MonoBehaviour
{
    [SerializeField] private Object streamingAsset;
    [SerializeField] private string filePath;

    [SerializeField] private VideoPlayer vidPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(filePath);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
