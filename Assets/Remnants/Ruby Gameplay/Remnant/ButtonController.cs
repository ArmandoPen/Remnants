using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    //Holds the name of the next level 
    public string nextLevelName;
    

    //Used by the button to load the scene 
    public void LoadScene()
    {
        SceneManager.LoadScene(nextLevelName);
    }
    
}
