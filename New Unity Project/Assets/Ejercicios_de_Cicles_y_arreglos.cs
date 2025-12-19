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

       
        string[] palabras = { "Todos ", "esos ", "momentos ", "se ", "perderan ", "en ", "el ", "tiempo ", "igual ", "que ", "lagrimas ", "en ", "la ", "lluvia " };
        string oracionCompleta = "";
        foreach(string palabra in palabras)
        {
            oracionCompleta += palabra + "";
        }

        Debug.Log(oracionCompleta.Trim());
        int[,] matriz = new int[2, 3];
        int[] vector = new int[3];
        int[] resultado = new int[2];
        Debug.Log("Matriz");
        for (int i = 0; i < 2; i++)
        {
            string fila = "";
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = Random.Range(1, 5);
                fila += matriz[i, j] + " ";
            }
            Debug.Log(fila);

        }
        Debug.Log("vector");
        for (int i = 0;i < vector.Length;i++)
        {
            vector[i] =Random.Range(1, 5);
            Debug.Log("vector["+i+"]=" + vector[i]);

        }
        for(int i = 0; i < 2; i++)
        {
            resultado[i] = 0;
            for(int j = 0;j < 3;j++)
            {
                resultado[i] += matriz[i, j] * vector[j];

            }
            Debug.Log("resultado["+i+"]=" + resultado[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
