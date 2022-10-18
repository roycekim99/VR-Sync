using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayer : MonoBehaviour
{
    [SerializeField] VideoPlayer vidPlayerObj;

    // Start is called before the first frame update
    void Start()
    {
        // What to show when first start up???
        Debug.Log(vidPlayerObj);
    }

    // Update is called once per frame
    void Update()
    {
        // Need to wait for Socket calls and act on socket calls
    }

    // 1. Update Render Texture when source change
        // --> need to make sure source and texture have same resolution
    // 2. 
}
