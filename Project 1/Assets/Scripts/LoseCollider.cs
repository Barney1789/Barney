using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D myCollider)
    {
        print("Game Over");
        print(myCollider.gameObject.name);
    }
}
