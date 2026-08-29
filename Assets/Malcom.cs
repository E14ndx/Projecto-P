using UnityEngine;

public class Malcom : MonoBehaviour
{
    public Kills Ki;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ki = GameObject.FindGameObjectWithTag("Ki").GetComponent<Kills>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Ki.suma(5);   
        }
    }
}
