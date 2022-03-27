using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
    private void Awake()
    {
        //   nextsence();
        Invoke("nextsence", 30);
    }

   void nextsence() 
    { 

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
