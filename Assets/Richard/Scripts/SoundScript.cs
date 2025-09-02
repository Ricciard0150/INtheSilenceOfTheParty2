using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource audioSource;   // arraste o AudioSource aqui no Inspector

    public AudioClip somColeta;       // arraste o som de coleta aqui

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Exemplo: som quando encosta em objeto coletável
        if (collision.CompareTag("Item"))
        {
            audioSource.PlayOneShot(somColeta);
            Debug.Log("Som executado!");
        }
    }
}

