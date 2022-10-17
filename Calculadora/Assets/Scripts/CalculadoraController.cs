using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculadoraController : MonoBehaviour
{

    [SerializeField]    private Text TextDisplayI;
    [SerializeField]    private Text TextDisplayII;
    void Start()
    {
        TextDisplayI.text = "";
        TextDisplayII.text = "";
    }

    public void BtnCharacter(string character)
    {
        TextDisplayII.text = character;
        TextDisplayI.text = TextDisplayI.text + TextDisplayII.text;
    }

}
