using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject prefabDiamond;

    // Nombre de pièce EN TOUT
    int piecesTotal;

    int piecesRecoltees = 0;

    AudioSource source;

   

    // Start is called before the first frame update
    void Start()
    {
        // Instantier la bonne quantité de pièces
        

        for (int i = 0; i < 8; i++)
        {
            // Déterminer la position
            Vector2 position = new Vector2(
                Random.Range(-3.5f, 2.5f),
                Random.Range(-3f, 4.5f));

            // Instantier
            Instantiate(prefabDiamond, position, Quaternion.identity);
        }

        // Trouver dynamiquement le nombre de pièces dans ma scène
        piecesTotal = FindObjectsOfType<Diamond>().Length;

        // Assigner l'audio source
        source = GetComponent<AudioSource>();

        

    }

    // Appelée lorsqu'une pièce est ramassée
    public void PieceRecoltee()
    {
        Debug.Log("Pièce récoltée");

        // Compter les pièces ramassées
        piecesRecoltees++;

        // Effet sonore
        source.Play();

        // Fin de partie?
        if (piecesRecoltees == piecesTotal)
        {
            Debug.Log($"GAME OVER! Durée de partie: {Time.time}");

            // Empêcher les mouvements du personnage
            FindObjectOfType<mouvement_Joueur>().enabled = false;


            // Charger la scène d'accueil
            SceneManager.LoadScene("Accueil");
        }
    }

}
