using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videoAcaba : MonoBehaviour {

    public VideoPlayer videoPlayer;

    // Use this for initialization
    void Start () {
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("escenaInicio2");
    }

    // Update is called once per frame
    void Update () {
         

        if (false)
        
        {
            
            SceneManager.LoadScene("escenaInicio2");
        }

    }
}
