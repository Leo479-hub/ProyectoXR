using UnityEngine;

public class CardInfo : MonoBehaviour
{
    public PopupManager popupManager;
    public Sprite fichaSprite;

    public void AbrirFicha()
    {
        popupManager.MostrarFicha(fichaSprite);
    }
}