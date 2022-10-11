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

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HandleInsertValue()
    {
        TextDisplayII.text = "1";
        TextDisplayI.text = TextDisplayI.text + " " + TextDisplayII.text;
    }

}
