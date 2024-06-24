using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public float speed;
    // Update is called once per frame

    private void Start() {
        speed = 6;
    }

    void Update()
    {
        float x = transform.position.x;
        transform.Translate(Vector2.left * speed * Time.deltaTime );
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            Destroy(other.gameObject);
        }
    }
}
