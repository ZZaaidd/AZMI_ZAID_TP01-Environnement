using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class AccueilManager : MonoBehaviour
{

    public Button btnJouer;
    public Button btnQuitter;



    // Start is called before the first frame update
    void Start()
    {

        btnJouer.onClick.AddListener(btnJouer_clicked);
        btnQuitter.onClick.AddListener(btnQuitter_clicked);




    }


    //quand le joueur clique sur JOUER
    void btnJouer_clicked()
    {
        // Charger la scène de jeu
        SceneManager.LoadScene("SampleScene");

        //Afficher le message dans la console
        Debug.Log("Le joueur a appuyé sur JOUER");
    }



    //quand le joueur clique sur QUITTER
    void btnQuitter_clicked()
    {
        //Afficher le message dans la console

        Debug.Log("Le joueur a appuyé sur QUITTER");
    }


}
