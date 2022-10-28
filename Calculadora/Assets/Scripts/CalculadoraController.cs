using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class CalculadoraController : MonoBehaviour
{

    [SerializeField] private Text TextDisplayI;
    [SerializeField] private Text TextDisplayII;

    private string _expression;
    private string _clear;
    private string _result;
    
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

    public void ExpressionCalculator()
    {
        _expression = TextDisplayI.text;
        DataTable table = new DataTable("tabela");
        _result = table.Compute(_expression, string.Empty).ToString();
        TextDisplayII.text = _result;
        TextDisplayI.text = "";
    }

    public void ClearAll()
    {
        TextDisplayI.text = "";
        TextDisplayII.text = "";
    }

    public void Clear()
    {
        _clear = TextDisplayI.text;
        string[] displayI = _clear.Split("");
        int tamanhoI = displayI.Length;
        int tamanhoF = tamanhoI - 1;
        displayI[tamanhoF] = "";
        TextDisplayI.text = string.Join(" ", displayI);
    }

}