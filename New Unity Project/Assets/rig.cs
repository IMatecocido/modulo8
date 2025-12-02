using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string texto1 = "1500";
        string texto2 = "2300";
        int numero1;
        int numero2;
        if (int.TryParse(texto1, out numero1) && int.TryParse(texto2, out numero2))
        {
            int suma = numero1 + numero2;
            Debug.Log("punto 1 - resultado de la suma" + suma);

        }
        else
        {
            Debug.Log("punto 1 - error: uno de los valores no es numerico");

        }
        string frase = "hola mundo";
        string resultadopar = "";
        for (int i = 0; i < frase.Length; i++)
        {
            if (i % 2 == 0)
                resultadopar += frase[i];

        }
        Debug.Log("punto 2 caracteres en indices pares:" + resultadopar);


        string oracion = "frase completa 100%";
        string OracionRecortada = oracion.Substring(5);
        Debug.Log ("punto 3 Oracion recortada:" +  OracionRecortada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
