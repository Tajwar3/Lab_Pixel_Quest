using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player5assets1 : MonoBehaviour

{
    public string nextLevel = "nextLevel";
    public int Coincount = 0;
    public int HealthCount = 3;
    public int maxhealth = 3;
    public Transform respawnPoint;
    private PlayerUIcontroller playui;
    public TextMeshPro text;
    public TextMeshProUGUI textUI;
    public int coinlevel = 0;

    private void Start()
    {
        playui = GetComponent<PlayerUIcontroller>();
        playui = UpdateHealth (HealthCount, maxhealth);
        coinlevel = GameObject.Find("CoinTextBackground").transform.childCount;
        playui.UpdateText (Coincount + "/" + coinlevel);
        playui.StartUI();
    }

    private PlayerUIcontroller UpdateHealth(int healthCount, int maxhealth)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D other)

    {

        switch (other.tag)
        {
            case "Death":
                {
                    HealthCount--;
                    if (HealthCount <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    { transform.position = respawnPoint.position; }
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
                    playui.UpdateText(Coincount + "/" + coinlevel);
                    Destroy(other.gameObject);
                    break;
                }
            case "Health":
                {
                    if (HealthCount <= 3)
                    {
                        HealthCount++;
                        Destroy(other.gameObject);
                        break;
                    }

                    HealthCount++;
                    Destroy(other.gameObject);
                    break;
                }

            case "Respawn":
                {
                    respawnPoint.position = other.transform.Find("Point").position;
                    break;
                }
                


        }
    }
}
