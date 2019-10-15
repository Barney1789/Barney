using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenwidthInUnits = 16f;
    Vector2 paddlePosition;



    // Start is called before the first frame update
    void Start()
    {
        paddlePosition = new Vector2(transform.position.x,transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos = (Input.mousePosition.x / Screen.width * screenwidthInUnits);

       //paddlePosition = new Vector2(mousePos, transform.position.y);

       paddlePosition.x = mousePos;
       
        transform.position = paddlePosition;
    }
}
