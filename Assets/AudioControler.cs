using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour
{

    public AudioSource[] src = new AudioSource[4];
    void Start()
    {
       for(int i=0;i<4;i++)
       {
           //src[i].Play();
        //    if(src[i].isPlaying)
        //    {
        //        i++;
        //        src[i].Play();
        //    }
       }  
       src[3].Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
