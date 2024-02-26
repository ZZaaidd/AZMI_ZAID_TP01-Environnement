using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    bool collected = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collected)
            return;


        // faire disparaitre le diamond
        Destroy(gameObject);

        collected = true;

        // Aviser le GameManager
        FindObjectOfType<GameManager>().DiamondRecoltee();
    }

}
