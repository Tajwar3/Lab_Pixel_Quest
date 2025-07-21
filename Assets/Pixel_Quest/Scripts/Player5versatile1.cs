using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player5versatile1 : MonoBehaviour
{

    private Rigidbody2D rb;
    public int fast = 7;
    private SpriteRenderer sr1;
    private int xMovement;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr1 = GetComponentInChildren<SpriteRenderer>();
        float xMovement = Input.GetAxis("Horizontal");
        
    }

    // Update is called once per frame
    private void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        // Debug.Log(xinput);
        rb.velocity = new Vector2(xinput * fast, rb.velocity.y);
        if (xMovement > 0) { sr1.flipX = true; }
        else if (xMovement < 0) { sr1.flipX = false; }

    }

}

