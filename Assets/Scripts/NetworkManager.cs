using System;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json.Linq;


public class NetworkManager : MonoBehaviour
{
    public static NetworkManager instance;
    public string URI;
    public SocketIOUnity client;

    VideoPlayerManager VP_manager;
    public bool handleSocketReceiving = true;   // TODO

    public void InitInstance(bool forceInit = false)
    {
        if (forceInit || instance == null)
        {
            Debug.Log("InitInstance");
            instance = this;
            var uri = new Uri("http://" + URI);
            client = new SocketIOUnity(uri);


            client.OnConnected += (sender, e) =>
            {
                Debug.Log("socket.onConnected");
            };

            client.OnUnityThread("start_video", res =>
            {
                Debug.Log("received start_video!");
                VP_manager.startVideo();

            });

            client.OnUnityThread("stop_video", res =>
            {
                Debug.Log("received stop_video!");
                VP_manager.stopVideo();

            });

            Debug.Log("Connecting to..." + uri.ToString());
            client.Connect();

            DontDestroyOnLoad(transform.root.gameObject);
        }
    }

    void Start()
    {
        // video player controller
        VP_manager = GameObject.FindGameObjectWithTag("Video Player Manager").GetComponent<VideoPlayerManager>();

        // com with server
        InitInstance();



    }

    void OnApplicationQuit()
    {
        handleSocketReceiving = false;
    }


}
