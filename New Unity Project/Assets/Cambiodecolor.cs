using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiodecolor : MonoBehaviour
{
    public string colortexto = "rojo";
    public Renderer rend;
    public float numeroflotante = 2.323123f;
    public string nombrecompleto = "Nehuen Camilo Alberto Rodriguez";
    public string nombreNovia = "Paula Lucia Lujan";

    // Start is called before the first frame update
    void Start()
    {
        string flotante4decimales = numeroflotante.ToString("f4");
        Debug.Log ("punto 5 - flotatne con 4 decimales" +  flotante4decimales);
        string nombre = nombrecompleto.Substring(0, 6);
        string segundonombre = nombrecompleto.Substring(6, 7);
        string Tercernombre = nombrecompleto.Substring(13, 8);
        string Apellido = nombrecompleto.Substring(21, 10);
        Debug.Log("Nombre" + nombre);
        Debug.Log("Segundonombre" + segundonombre);
        Debug.Log("TercerNombre" + Tercernombre); 
        Debug.Log("Apellido" + Apellido);
        string[] partes = nombreNovia.Split(' ');
        
        string nombrNovia = partes[0];
        string segundorombreNovia = partes[1];
        string apellido = partes[2];

        Debug.Log("nombre:" + nombrNovia);
        Debug.Log("segundonombre:" + segundorombreNovia);
        Debug.Log("apellido:" + apellido);

    }

    // Update is called once per frame
    void Update()
    {
        switch (colortexto)
        {
            case "rojo":
                rend.material.color = Color.red;
                break;

            case "verde":
                rend.material.color = Color.green;
                break;

            case "azul":
                rend.material.color = Color.blue;
                break;

            default:
                rend.material.color = Color.white;
                break;

        }

    }
}
