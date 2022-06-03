using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNavigation : MonoBehaviour
{
    [SerializeField] GameObject optionsPanel;
    [SerializeField] GameObject PausePanel;
    [SerializeField] GameObject EndPanel;

    public bool PlayMenuSong = false;

    private void Start()
    {
        if (PlayMenuSong)
        {
            
            GameManager.Instance.PlaySong("menu");
        }
        else
        {
            GameManager.Instance.PlaySong("game");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }

        if (GameManager.Instance.gameWon)
        {
            End();
        }
    }

    public void ChangeScene(string scene)
    {
        GameManager.Instance.LoadScene(scene);
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
    }

    public void Close()
    {
        optionsPanel.SetActive(false);
    }

    public void Quit()
    {
        GameManager.Instance.Quit();
    }

    private void End()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 0;
        EndPanel.SetActive(true);
    }

    public void SelectCharacter(string character)
    {

        GameManager.Instance.activeCharacter = (character == "male") ? GameManager.Instance.maleCharacter : GameManager.Instance.femaleCharacter;

    }

    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
}
