using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement_Joueur : MonoBehaviour
{
    float horizontale;
    float verticale;
    float moveLimiter = 0.5f;

    public float movementSpeed = 10.0f;

    Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // Récupérer les valeurs des inputs (l'axe des abcisses et l'axe des ordonnées)
        horizontale = Input.GetAxisRaw("Horizontal"); 
        verticale = Input.GetAxisRaw("Vertical"); 
    }


    void FixedUpdate()
    {
        if (horizontale != 0 && verticale != 0) 
        {
            // limite la vitesse de mouvement diagonale
            horizontale *= moveLimiter;
            verticale *= moveLimiter;
        }

        body.velocity = new Vector2(horizontale * movementSpeed, verticale * movementSpeed);
    }
}


