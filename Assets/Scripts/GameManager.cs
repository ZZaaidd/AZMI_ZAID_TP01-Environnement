using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject prefabDiamond;

    // Nombre de pièce EN TOUT
    int diamondsTotal;

    int diamondsRecoltees = 0;

    AudioSource audiosource;

   

    // Start is called before the first frame update
    void Start()
    {
        // Instantier une quantité de 8 diamonds  
        

        for (int i = 0; i < 8; i++)
        {
            // Déterminer la position selon le jeu
            Vector2 position = new Vector2(
                Random.Range(-3.5f, 2.5f),
                Random.Range(-3f, 4.5f));

            // Instantier les diamonds
            Instantiate(prefabDiamond, position, Quaternion.identity);
        }

        // Trouver dynamiquement le nombre de diamonds dans la scène
        diamondsTotal = FindObjectsOfType<Diamond>().Length;

        // Assigner l'audio source
        audiosource = GetComponent<AudioSource>();

        //  jouer la musique du fond
        audiosource.Play();

    }

    // Appelée lorsqu'une pièce est ramassée
    public void DiamondRecoltee()
    {
        Debug.Log("Diamond récolté");

        // Compter le nombre de diamonds ramassés
        diamondsRecoltees++;


        // vérifier la partie est terminée ou pas encore
        if (diamondsRecoltees == diamondsTotal)
        {
            Debug.Log($"GAME OVER! Durée de partie: {Time.time}");

            // Empêcher les mouvements du personnage
            FindObjectOfType<mouvement_Joueur>().enabled = false;


            // Charger la scène d'accueil
            SceneManager.LoadScene("Accueil");
        }
    }

}
