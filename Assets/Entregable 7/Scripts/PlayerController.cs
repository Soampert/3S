using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float horizontalInput;
    public float speed = 10f;
    public float yRange = 14;

    private bool isOnGround;
    public bool gameOver;

    private SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {

        gameOver = false;

        rb = GetComponent<Rigidbody>();

        soundManager = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && gameOver == false)
        {
            rb.velocity = new Vector3(0f, 4f, 0f);

            soundManager.SeleccionAudio(1, 1f);
        }

        {

        
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

            if (transform.position.y > yRange)
            {
                transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
            }

            {
                if (transform.position.y <= 2.248269)
                    Debug.Log(message: "salchichon");
            }

            {
                if (transform.position.y <= 2.248269)
                    isOnGround = true;
            }

        }
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Ground"))
            gameOver = true;

        if (otherCollider.gameObject.CompareTag("Bomb"))
            gameOver = true;


    }
}





