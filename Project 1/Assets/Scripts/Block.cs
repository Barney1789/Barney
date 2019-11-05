using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    GameStatus gs;

    // Start is called before the first frame update

    void Start()
    {
        gs = FindObjectOfType<GameStatus>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject);
        gs.AddToScore();
    }


    // Update is called once per frame
    void Update()
    {
       

    }
}
