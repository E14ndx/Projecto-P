using System;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;
public class REPRODUCCION : MonoBehaviour
{
    public GameObject Diglett_ria;
    public float Tiempodeegg = 2;
    private float tiemporizador = 0;
    public float seteescapa = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Al separar el comando que espawnea diglerias a una funcion aparte permite utilizarla de forma paralela sin modificar la estructura de la funcion
        egg();
    }

    // Update is called once per frame
    void Update()
    {
        if(tiemporizador < Tiempodeegg)
        {
            tiemporizador += Time.deltaTime;
        }else
        {
        //Al separar el comando que espawnea diglerias a una funcion aparte permite utilizarla de forma paralela sin modificar la estructura de la funcion
        egg();
        tiemporizador = 0;
        }
    }
    void egg()
    {
        float Arriba = transform.position.y + seteescapa;
        float Abajo = transform.position.y - seteescapa;
        //Gracias a esto espawnean diglerias :p
        Instantiate(Diglett_ria, new Vector3(transform.position.x, Random.Range(Arriba,Abajo),0), transform.rotation);
    }
}
