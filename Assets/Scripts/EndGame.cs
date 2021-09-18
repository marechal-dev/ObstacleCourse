using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        bool colliderIsPlayer = collision.gameObject.tag == "Player";

        if (colliderIsPlayer)
        {
            Application.Quit();
        }
    }
}
