using UnityEngine;

public class CondiçãoDeVitoria : MonoBehaviour
{
    public Inventory inventory; // arrasta o Inventory aqui no inspector
    public TimerScript timerScript; // arrasta o TimerScript no inspector
    public GameObject porta;

    private void Start()
    {
        porta.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Corrigido
        {
            // Verifica se o jogador coletou todos os itens possíveis
            if (inventory.items.Count == inventory.maxSlots)
            {
                // Verifica se ainda há tempo no cronômetro
                if (timerScript.timerRemaining > 0)
                {
                    porta.SetActive(false);
                    Debug.Log(" U did it!");
                }
                else
                {
                    Debug.Log(" Tempo acabou!");
                }
            }
            else
            {
                Debug.Log("Você ainda não pegou todos os itens!");
            }
        }
    }
}