using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void IniciarExperiencia()
    {
        SceneManager.LoadScene("SampleScene");
    }
}