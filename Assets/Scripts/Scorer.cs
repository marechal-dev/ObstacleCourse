using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        bool objectWasNotHit = collision.gameObject.tag != "Hit";
        bool colliderIsNotGround = collision.gameObject.tag != "Ground";

        if (objectWasNotHit && colliderIsNotGround)
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
    }
}
