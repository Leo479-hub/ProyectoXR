using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Abre la escena Colecciones
    public void AbrirColecciones()
    {
        SceneManager.LoadScene("Colecciones");
    }
}