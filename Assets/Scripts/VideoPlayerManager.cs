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
    [SerializeField] private string filePath;
    [SerializeField] private Object streamingAsset;
    [SerializeField] private UnityEngine.Video.VideoPlayer vidPlayer;

    // Start is called before the first frame update
    void Start()
    {
        string videoDirectoryPath = Application.dataPath + "/_Videos";
        Debug.Log(videoDirectoryPath);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setTime(string time)
    {

    }

    // change source video url
    // 1. Update Render Texture when source change
    // --> need to make sure source and texture have same resolution
    // 2. 
    void loadVideo(string videoURL)
    {

        Debug.Log(videoURL);
    }
    public void startVideo()
    {
        vidPlayer.Play();
    }

    public void stopVideo()
    {
        vidPlayer.Stop();
    }



}
