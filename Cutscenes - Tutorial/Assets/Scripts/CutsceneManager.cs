using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour
{
    public PlayableDirector playableDirector;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            playableDirector.Play();
        }
    }
}
