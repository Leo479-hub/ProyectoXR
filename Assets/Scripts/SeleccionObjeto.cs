using UnityEngine;
using UnityEngine.EventSystems;

public class SeleccionObjeto : MonoBehaviour
{
    private GameObject panelActivo;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Si hay panel abierto y tocó fuera, cerrar
                if (panelActivo != null)
                {
                    if (!RectTransformUtility.RectangleContainsScreenPoint(
                        panelActivo.GetComponent<RectTransform>(),
                        touch.position))
                    {
                        panelActivo.SetActive(false);
                        panelActivo = null;
                        return;
                    }
                }

                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    InformacionPieza info =
                        hit.collider.GetComponent<InformacionPieza>();

                    if (info != null)
                    {
                        if (panelActivo != null)
                            panelActivo.SetActive(false);

                        info.panelInformacion.SetActive(true);
                        panelActivo = info.panelInformacion;
                    }
                }
            }
        }
    }
}