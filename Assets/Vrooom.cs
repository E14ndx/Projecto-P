using UnityEngine;

public class Vrooom : MonoBehaviour
{
    //Primero creamos una variable que alterara la posicion del objeti
    public float Movimiento = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Trasnform.position: cambiara la posicion del objeto   Vector3.left: Unity siempre opera en 3 dimensiones por lo que indicas que el objeto en cuestion se movera a la izquierda    Time.deltatime: ignora el tiempo real si no que usara los fps del usuario para operar
        transform.position += Vector3.left * Movimiento * Time.deltaTime;
    }
}
