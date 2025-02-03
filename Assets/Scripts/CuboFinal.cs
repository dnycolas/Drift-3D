using UnityEngine;

public class CuboFinal : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Chama o script Cronometro para pausar o tempo
            Cronometro relogioScript = collision.gameObject.GetComponent<Cronometro>();
            if (relogioScript != null)
            {
                relogioScript.PausarCronometro();
                Debug.Log("Cronômetro pausado ao colidir com o cubo!");
            }
        }
    }
}