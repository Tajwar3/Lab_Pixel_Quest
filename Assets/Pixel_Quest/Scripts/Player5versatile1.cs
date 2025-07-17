using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player5versatile1 : MonoBehaviour
{

    private Rigidbody2D rb;
    public int fast = 7;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        // Debug.Log(xinput);
        rb.velocity = new Vector2(xinput * fast, rb.velocity.y);

    }

}

