using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{

    public float speed = 5f;
    public float yLim = -15f;

    private PlayerController playerControllerScript;

    private bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }


    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Player"))
            gameOver = true;
    }


    // Update is called once per frame
    void Update()
    {


        if (gameOver == false)

            transform.Translate(Vector3.left * speed * Time.deltaTime);

        else transform.Translate(Vector3.left * 0 * Time.deltaTime);


        /*
        if (gameOver == true)

            transform.Translate(0, 0, 0);
        */
    }

    
}
