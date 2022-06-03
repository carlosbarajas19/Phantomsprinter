using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] Transform PlayerSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        GameManager.Instance.gameWon = false;

        Time.timeScale = 1;
        Instantiate(GameManager.Instance.activeCharacter, PlayerSpawn.position, PlayerSpawn.rotation);
    }
}
