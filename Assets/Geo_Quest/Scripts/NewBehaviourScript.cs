using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private string var1 = "Hello";
    
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public int fast = 7;
    public string nextLevel = "nextLevel";
    public float moveSpeed = 5f;
    public float jumpforce = 10f;
    public float groundcheckradius = .2f;
    public LayerMask groundLayer;
    private bool isgrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        string var2 = "world";
        Debug.Log("Hello world");
        Debug.Log(var1 + var2);
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics2D.OverlapCircle(transform.position - new Vector3(0, 0.5f, 0), groundcheckradius, groundLayer);

        float xinput = Input.GetAxis("Horizontal");
       // Debug.Log(xinput);
        rb.velocity = new Vector2(xinput * fast, rb.velocity.y);

        if (isgrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sprite.color = Color.green; 
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sprite.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sprite.color = Color.red;
        }

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
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }


            }
    }



}


