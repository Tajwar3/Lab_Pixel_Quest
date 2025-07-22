using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player5assets1 : MonoBehaviour

{
    public string nextLevel = "nextLevel";
    public int Coincount = 0;
    public int HealthCount = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        switch (other.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Coin":
                {
                    Coincount++;
                    Destroy(other.gameObject);
                    break;
                }
            case "Health":
                {
                    HealthCount++;
                    Destroy(other.gameObject);
                    break;
                }




        }
    }
}
