using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMananger : MonoBehaviour
{
    private bool ismuted; 
    // Start is called before the first frame update
    void Start()
    {
        ismuted = false;
    }

   
    public void Ismutepress()
    {
        ismuted = !ismuted;
        AudioListener.pause = ismuted;
    }
}