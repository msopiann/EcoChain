using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement : MonoBehaviour
{

    [SerializeField] AudioSource music;

    public static SoundManagement instance = null;

    public void PlayMusic()
    {
        music.Play();
    }

    public void PauseMusic()
    {
        music.Pause();
    }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

}
