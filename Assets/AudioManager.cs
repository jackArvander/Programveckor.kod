using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

// skapad av vincent fajersson
public class AudioManager : MonoBehaviour 
{
    // Ljud - Vincent
    public static AudioManager Instance; // gör så att allting kan använda denna script

    public Sound[] musicSounds, sfxSounds; // skapar en array för att ha informationen av ljud 
    public AudioSource musicSource, sfxSource; // skapar en array för att ha informationen av musik 

    private void Awake()
    {
        if (Instance == null) // ifall det inte finns en AudioManager i spelet så gör den en AudioManager 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // förstör INTE AudioManager när spelet
        }
        else
        {
            Destroy(gameObject); // ifall det redan finns en AudioManager i spelet så förstör den denna objekt så det inte blir massor med errors.
        }
    }

    private void Start()
    {
        PlayMusic("Theme"); // spelar musiken när man öppnar spelet
    }

    public void PlayMusic(string name) // går igenom array som vi skapade i början för att hitta musik
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound not found"); // säger till ifall den inte kan hitta ljud effekt som vi ska använda
        }

        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name); // går igenom array som vi skapade i början för att hitta ljud effekter

        if (s == null)
        {
            Debug.Log("Sound not found"); // säger till ifall den inte kan hitta ljud effekt som vi ska använda
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }

}
