using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    private string var1 = "Hello";
    int var3 = 3;
    private Rigidbody2D rb;
    public int fast = 7;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        string var2 = "world";
        Debug.Log("Hello world");
        Debug.Log(var1 + var2);
        
    }

    // Update is called once per frame
    void Update()
    {


        float xinput = Input.GetAxis("Horizontal");
       // Debug.Log(xinput);
        rb.velocity = new Vector2(xinput * fast, rb.velocity.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            switch(collision.tag)
            {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }


            }
    }











}


