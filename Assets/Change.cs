using UnityEngine;

public class Change : MonoBehaviour
{
    //esto deberia dejar manipular el rigidbody :p
    public Rigidbody2D Pollorigido;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Pollones";
    }

    // Update is called once per frame
    void Update()
    {
        //con esto el pollo en cada frame subira (0,1)*10
        Pollorigido.linearVelocity = Vector2.up * 10;
    }
}
