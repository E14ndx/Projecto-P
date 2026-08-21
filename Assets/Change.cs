using UnityEngine;
using UnityEngine.InputSystem;

public class Change : MonoBehaviour
{
    //esto deberia dejar manipular el rigidbody :p
    public Rigidbody2D Pollorigido;
    //gracias a esto puedes modificar la varible Fly que es el alto con lo que el pajaro vuela durante unity
    public float Fly;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "PoJhons";
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
          //con esto el pollo en cada frame subira (0,1)*10 cada vez que apretes "barra espaciadora"
        Pollorigido.linearVelocity = Vector2.up * Fly;  
        }
        
    }
}
