using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    PlayerMovement PlayerMovement;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Startbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
   public void Exitbutton()
    {
        Application.Quit();
    }

      
}
