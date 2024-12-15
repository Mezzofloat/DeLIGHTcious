using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MenuButton
{
    public void StartLater() {
        Invoke("StartGame", 1);
    }

    void StartGame() {
        SceneManager.LoadScene(1);
    }
}
