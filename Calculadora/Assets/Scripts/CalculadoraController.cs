using UnityEngine;
using UnityEngine.UI;
using System.Data;
using System;

public class CalculadoraController : MonoBehaviour
{
    [SerializeField] private Text TextDisplayI;
    [SerializeField] private Text TextDisplayII;

    private string _expression, _clear, _result, _lastNumber;
    private float _var;
    private double _sin, _cos, _tan, _per;

    void Start()
    {
        TextDisplayI.text = "";
        TextDisplayII.text = "";
    }

    public void BtnCharacter(string character)
    {
        _lastNumber = character;
        TextDisplayII.text = _lastNumber;
        TextDisplayI.text = TextDisplayI.text + TextDisplayII.text;
    }

    public void ExpressionCalculator()
    {
        _expression = TextDisplayI.text;
        DataTable table = new DataTable("tabela");
        _result = table.Compute(_expression, string.Empty).ToString();
        TextDisplayII.text = "=" + _result;
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
        string[] displayI = _clear.Split(_lastNumber);
        int tamanhoI = displayI.Length;
        int tamanhoF = tamanhoI - 1;
        displayI[tamanhoF] = "";
        TextDisplayI.text = string.Join(_lastNumber, displayI);
    }

    public void Sin()
    {
        _var = float.Parse(TextDisplayII.text);
        _sin = Math.Sin(_var);
        TextDisplayII.text = "=" + _sin;
        TextDisplayI.text = "";
    }

    public void Cos()
    {
        _var = float.Parse(TextDisplayII.text);
        _cos = Math.Cos(_var);
        TextDisplayII.text = "=" + _cos;
        TextDisplayI.text = "";
    }

    public void Tan()
    {
        _var = float.Parse(TextDisplayII.text);
        _tan = Math.Tan(_var);
        TextDisplayII.text = "=" + _tan;
        TextDisplayI.text = "";
    }

    public void Percentage()
    {
        _var = float.Parse(TextDisplayI.text);
        _per = _var / 100;
        TextDisplayII.text = "=" + _per;
        TextDisplayI.text = "";
    }
}