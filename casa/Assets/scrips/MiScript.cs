using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript : MonoBehaviour
{
    public string miNombre;
    public string mensajedebienvenida;
    public int papas;
    public int salchichas;
    private int suma;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(mensajedebienvenida + miNombre);

        suma = papas + salchichas;

        Debug.Log(suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
