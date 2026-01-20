using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void Startbutton()
    {
        TransitionManager.Instance.Startbutton();
    }

    public void QuitgameButton()
    {
        TransitionManager.Instance.QuitgameButton();
    }

    public void Quit()
    {
        TransitionManager.Instance.QuitButton();
    }

}
