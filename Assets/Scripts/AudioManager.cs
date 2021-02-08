using UnityEngine;
using UnityEngine.Audio;
using System;
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    private void Awake()
    {
        if (instance !=null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.playOnAwake = s.PlayOnAwake;
        }
    }
    private static AudioManager instance = null;
    public static AudioManager Instance
    {
        get { return instance; }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Sound : " + name + " not found!");
            return;
        }
        s.source.Play();
    }
}
