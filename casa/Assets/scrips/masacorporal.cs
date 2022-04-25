using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masacorporal : MonoBehaviour
{
    public string nombreDeUsuario;
    public float altura;
    public float peso;
    private float operacion;
    private float IMC;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(nombreDeUsuario);
        operacion = altura * altura;
        IMC = peso / operacion;
        Debug.Log(IMC);

        if (IMC <= 18.6 || IMC >= 25.0)
        {
            Debug.Log("incorrecto");
        }
        else
        {
            Debug.Log("correcto");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
