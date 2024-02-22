using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    void btnJouer_clicked()
    {
        Debug.Log("Le joueur a appuyé sur JOUER");
    }


    void btnQuitter_clicked()
    {
        Debug.Log("Le joueur a appuyé sur QUITTER");
    }


}
