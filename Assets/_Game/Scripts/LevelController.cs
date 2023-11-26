using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;


public class LevelController : MonoBehaviour
{

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        if (Keyboard.current[Key.I].wasPressedThisFrame)
        {
            ExitLevel();
        }
    }
    public void ExitLevel()
    {
        SceneManager.LoadScene("InventoryWindow2");
    }
}
