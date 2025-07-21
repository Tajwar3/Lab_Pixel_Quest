using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1jump1 : MonoBehaviour
{
    public float jumpforce = 10f;
    public Rigidbody2D rb;
    public bool tung;
    public float CapsuleHeight = .25f;
    public float CapsuleRadius = 0.08f;

    public Transform feetcollider;
    public LayerMask groundMask;
    private Vector2 gravity;
    private float fallforce = 1;
    private bool waterCheck;
    // Start is called before the first frame update
    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();



        gravity = new Vector2(0f, Physics2D.gravity.y);




    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Water") { waterCheck = true; }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Water") { waterCheck = false; }




        // Update is called once per frame
        void Update()
        {
            float yinput = Input.GetAxis("Vertical");

            tung = Physics2D.OverlapCapsule(point: feetcollider.position, new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundMask);

            if (Input.GetKeyUp(KeyCode.Space) && tung)


            {


                rb.velocity = new Vector2(rb.velocity.x, jumpforce);

            }
            if (rb.velocity.y < 0)
            {
                rb.velocity += gravity * (fallforce * Time.deltaTime);
            }
        }
    }
}
