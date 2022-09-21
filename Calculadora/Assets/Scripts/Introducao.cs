using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introducao : MonoBehaviour
{
    //Tipos de Variáveis
    [SerializeField] private string _name = "Thiago Garcia";
    public string Name = "Thiago";
    private string texto;
    private float decimalNumber = 0.0f;
    bool isActive = false;
    private int  index = 0; 
 
    Transform position;
    GameObject _object;

    void Start()
    {
        Debug.Log(Name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
