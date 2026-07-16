using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    public GameObject popup;
    public Image ficha;

    public void MostrarFicha(Sprite imagen)
    {
        ficha.sprite = imagen;
        popup.SetActive(true);
    }

    public void CerrarFicha()
    {
        popup.SetActive(false);
    }

    private void Update()
    {
        if (popup.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            CerrarFicha();
        }
    }
}