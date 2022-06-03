using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] public GameObject maleCharacter;
    [SerializeField] public GameObject femaleCharacter;
    [SerializeField] StringData currentSong;
    public AudioSource Source;
    public AudioClip menuSong;
    public AudioClip gameSong;


    public GameObject activeCharacter { get; set; }
    public bool gameWon { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        activeCharacter = maleCharacter;
        currentSong.value = "song";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySong(string song)
    {
        if (song.Equals("menu"))
        {
            if (!currentSong.value.Equals(song))
            {
                Source.clip = menuSong;
                currentSong.value = song;
                Source.Play();
            }
        }
        else if (song.Equals("game"))
        {
            if (!currentSong.value.Equals(song))
            {
                Source.clip = gameSong;
                currentSong.value = song;
                Source.Play();
            }
        }
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
