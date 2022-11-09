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

    private void Awake()
    {
        Caching.compressionEnabled = false;
        vidPlayer.Prepare();
    }

    // Start is called before the first frame update
    void Start()
    {
        string videoDirectoryPath = Application.dataPath + "/_Videos";
        Debug.Log(videoDirectoryPath);

        vidPlayer.playOnAwake = false;
        vidPlayer.frame = 0;
        vidPlayer.Pause();

        Debug.Log("Video paused at VPM.Start()");
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

        Debug.Log("will load: " + videoURL);
        vidPlayer.url = videoURL;
        vidPlayer.Prepare();
    }
    public void startVideo()
    {
        Debug.Log("CALLED PLAY");

        if (vidPlayer.isPrepared)
        {
            vidPlayer.Play();
        }
        else
        {
            Debug.Log("Video not ready yet...");
            vidPlayer.Prepare();
        }
    }

    public void stopVideo()
    {
        Debug.Log("CALLED STOP");
        vidPlayer.Stop();
    }



}
