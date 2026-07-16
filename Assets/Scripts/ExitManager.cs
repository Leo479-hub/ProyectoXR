using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitManager : MonoBehaviour
{
    public GameObject exitPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitPanel.SetActive(!exitPanel.activeSelf);
        }
    }

    public void Continuar()
    {
        exitPanel.SetActive(false);
    }

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}