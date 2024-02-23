using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    bool collectee = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collectee)
            return;

        //Debug.Log("OnCollisionEnter2D");

        // Disparition de la pièce
        Destroy(gameObject);

        collectee = true;

        // Aviser le GameManager
        FindObjectOfType<GameManager>().PieceRecoltee();
    }

}
