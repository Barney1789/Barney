using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle myPaddle;

    [SerializeField] AudioClip[] ballsounds;

    Vector2 paddleToBallDistance;

    bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallDistance = this.transform.position - myPaddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
        }
        //this.transform.position = myPaddle.transform.position + paddleToBallDistance;

        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);

        }

    }


    private void LockBallToPaddle()
    {
        Vector2 paddlePosition = myPaddle.transform.position;
        this.transform.position = paddlePosition + paddleToBallDistance;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (hasStarted)
        {
            // GetComponent<AudioSource>().Play();
            int randomNumber = UnityEngine.Random.Range(0, ballsounds.Length);
            AudioClip sound = ballsounds[randomNumber];

            GetComponent<AudioSource>().PlayOneShot(sound);
        }
    }
}
