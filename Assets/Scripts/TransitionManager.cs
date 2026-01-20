using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransitionManager : MonoBehaviour
{
    public static TransitionManager Instance;

     private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
   public void Startbutton()
    {
          SceneManager.LoadScene(0);
    }

    public void QuitgameButton()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
        Debug.Log("ilang");
        Application.Quit();
        
    }
}
