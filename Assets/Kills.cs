using UnityEngine;
using UnityEngine.UI;
public class Kills : MonoBehaviour
{
    public int Killss;
    public Text Puntaje;
    [ContextMenu("Actualizar")]
    void Start()
    {
        Killss = 0;
    }
    public void suma()
    {
        Killss += 1;
        Puntaje.text = Killss.ToString();
    }
}
