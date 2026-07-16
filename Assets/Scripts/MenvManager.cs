using UnityEngine;
using UnityEngine.SceneManagement;

public class MenvManager : MonoBehaviour
{
    public void AbrirColecciones()
    {
        SceneManager.LoadScene("Colecciones");
    }

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}