using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Music[] clips;

    int i;

    private void Awake()
    {
        //If another instance of Audiomanager exists in another scene, destroy this
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        //Referencing each property of an AudioSource
        foreach(Music m in clips)
        {
            m.source = gameObject.AddComponent<AudioSource>();
            m.source.clip = m.clip;

            m.source.volume = m.volume;
            m.source.pitch = m.pitch;
            m.source.loop = m.loop;
        }
    }

    private void Start()
    {
       
    }

    public void Play(string name)
    {
        Music m = Array.Find(clips, music => music.name == name);
        if (m == null)
            return;
        m.source.Play();
    }

    public void Stop(string name)
    {
        Music m = Array.Find(clips, music => music.name == name);
        if (m == null)
            return;
        m.source.Stop();
    }

    

    public void Pause(string name)
    {
        Music m = Array.Find(clips, music => music.name == name);
        if (m == null)
            return;
        m.source.Pause();
    }

    public void UnPause(string name)
    {
        Music m = Array.Find(clips, music => music.name == name);
        if (m == null)
            return;
        m.source.UnPause();
    }

}
