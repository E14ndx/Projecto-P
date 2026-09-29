using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Kills : MonoBehaviour
{
    public int Killss;
    public Text Puntaje;
    [ContextMenu("Actualizar")]
    void Start()
    {
        Killss = 0;
    }
    public void suma(int puntos)
    {
        Killss += puntos;
        Puntaje.text = Killss.ToString();
    }

    public void Reseteo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
