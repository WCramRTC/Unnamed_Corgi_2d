using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public CorgiScriptableObject cso;
    public GameObject art;
    public float speed;
    public float jump;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        speed = cso.speed;
        jump = cso.jumpForce;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();
        
        if(Input.GetButtonDown("Jump")) {
            Jump();
        }
    }

    public void Move() {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(horizontal, 0);

        if(horizontal > 0) art.transform.localScale = new Vector3(1,1,1);
        else if(horizontal < 0) art.transform.localScale = new Vector3(1,-1,1);

        transform.Translate(move * speed * Time.deltaTime);
    }

    public void Jump() {
                    rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
    }
}
