using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class Ejercicios_de_Cicles_y_arreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int tamaño = 10;

        int[] arr1 = new int[tamaño];
        int[] arr2 = new int[tamaño];
        int[] arr3 = new int[tamaño];

        for (int i = 0; i < tamaño; i++)
        {
            arr1[i] = Random.Range(1, 10);
            arr2[i] = Random.Range(1, 10);

            arr3[i] = arr1[i] + arr2[i];



        }
        for (int i = 0; i < tamaño; i++)
        {
            Debug.Log(arr3[i]);
        }

        Debug.Log("Ejercicio2");
        string[] palabras = { "Todos ", "esos ", "momentos ", "se ", "perderan ", "en ", "el ", "tiempo ", "igual ", "que ", "lagrimas ", "en ", "la ", "lluvia " };
        string oracionCompleta = "";
        foreach(string palabra in palabras)
        {
            oracionCompleta += palabra + "";
        }

        Debug.Log(oracionCompleta.Trim()); 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
