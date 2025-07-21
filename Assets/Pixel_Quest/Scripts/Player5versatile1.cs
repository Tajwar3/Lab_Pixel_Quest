
using UnityEngine;

public class Player5versatile1 : MonoBehaviour
{

    private Rigidbody2D rb;
    public int fast = 7;
    private SpriteRenderer sr1;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr1 = GetComponentInChildren<SpriteRenderer>();
        
        
    }

    // Update is called once per frame
    private void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        // Debug.Log(xinput);
        rb.velocity = new Vector2(xinput * fast, rb.velocity.y);
        if (xinput > 0) { sr1.flipX = true; }
        else if (xinput < 0) { sr1.flipX = false; }

    }

}

