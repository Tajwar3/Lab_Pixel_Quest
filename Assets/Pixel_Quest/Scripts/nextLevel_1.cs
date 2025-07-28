using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel_1 : MonoBehaviour
{

    // Start is called before the first frame update
    public string NextLevel;
   public void LoadLevel()
    {
       SceneManager.LoadScene(NextLevel);
        
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
    void Update()
    {
        
    }
}
