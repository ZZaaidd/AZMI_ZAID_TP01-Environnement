using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MenuParamètres : MonoBehaviour
{
    // définir les éléments du menu Paramètres
    public Toggle toggle;
    public Slider slider;
    public TMP_Dropdown dropdown;
    public TMP_InputField inputField;
    



    // Start is called before the first frame update
    void Start()
    {
        // Assigner les Event Listener
        toggle.onValueChanged.AddListener(toggle_checked);
        slider.onValueChanged.AddListener(slider_onValueChanged);
        dropdown.onValueChanged.AddListener(dropdown_onValueChanged);
        inputField.onValueChanged.AddListener(inputField_onValueChanged);

    }


    //afficher la valeur du Toggle dans la console.
    void toggle_checked(bool value)
    {
        Debug.Log($"Le toggle est maintenant {value}");

    }


    //afficher la valeur du Slider dans la console.
    void slider_onValueChanged(float valeur)
    {
        Debug.Log($"Le slider est maintenant à: {valeur}");
    }



    //afficher l'option choisie dans la console (0 pour A, 1 pour B, 2 pour C)
    void dropdown_onValueChanged(int valeur)
    {
        Debug.Log($"L'option est maintenant: {valeur}");
    }



    //afficher le contenu écrit.
    void inputField_onValueChanged(string valeur)
    {
        Debug.Log($"Le nom est maintenant: {valeur}");
    }
}
