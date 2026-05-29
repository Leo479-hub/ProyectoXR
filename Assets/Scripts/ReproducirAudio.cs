using UnityEngine;
using Vuforia;

public class ReproducirAudio : MonoBehaviour
{
    private AudioSource audioSource;
    private ObserverBehaviour observerBehaviour;

    void Start()
    {
        // Obtiene el AudioSource
        audioSource = GetComponent<AudioSource>();

        // Obtiene el ImageTarget de Vuforia
        observerBehaviour = GetComponent<ObserverBehaviour>();

        // Detecta cuando se pierde el target
        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    public void ControlarAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        // Si el target ya NO está detectado
        if (status.Status == Status.NO_POSE)
        {
            audioSource.Stop();
        }
    }

    void OnDestroy()
    {
        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }
}