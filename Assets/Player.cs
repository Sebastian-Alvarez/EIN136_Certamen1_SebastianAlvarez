using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed;
    private Rigidbody2D rb;
    private float x, y;
    private float valorDeEscala;
    private int puntaje;

    void Start()
    {
        puntaje = 0;
        valorDeEscala = 0.2f;
        speed = 8f;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (gameObject.transform.localScale.x <= 0.1f)
        {
            Debug.Log("Game Over");
            Debug.Log("Puntaje: " + puntaje);
            Destroy(gameObject);
        }

        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x,y)*speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Red")
        {
            puntaje -= 5;
            Destroy(collision.gameObject);
            transform.localScale +=  transform.localScale*(-valorDeEscala)*2;
        }
        if (collision.gameObject.name == "Blue")
        {
            puntaje += 10;
            Destroy(collision.gameObject);
            transform.localScale += transform.localScale * valorDeEscala;
        }
    }
}
