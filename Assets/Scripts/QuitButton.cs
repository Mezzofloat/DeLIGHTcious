using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MenuButton
{
    public void QuitLater(float t) => Invoke("Quit", t);

    // TODO: change to Application.Quit() before building
    public void Quit() => Application.Quit();
}
