using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MenuParamètres : MonoBehaviour
{

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

    void toggle_checked(bool value)
    {
        Debug.Log($"Le toggle est maintenant {value}");


    }

    void slider_onValueChanged(float valeur)
    {
        Debug.Log($"Le slider est maintenant à: {valeur}");
    }

    void dropdown_onValueChanged(int valeur)
    {
        Debug.Log($"L'option est maintenant: {valeur}");
    }


    void inputField_onValueChanged(string valeur)
    {
        Debug.Log($"Le nom est maintenant: {valeur}");
    }
}
