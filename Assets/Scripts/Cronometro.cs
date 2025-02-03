using TMPro;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    private TextMeshProUGUI textTela;
    private float tempoDecorrido;
    private bool cronometroAtivo = true;

    void Start()
    {
        textTela = GetComponent<TextMeshProUGUI>();
        tempoDecorrido = 0f;
    }

    void Update()
    {
        if (cronometroAtivo)
        {
            tempoDecorrido += Time.deltaTime;

            int minutos = Mathf.FloorToInt(tempoDecorrido / 60f);
            int segundos = Mathf.FloorToInt(tempoDecorrido % 60f);
            int milissegundos = Mathf.FloorToInt((tempoDecorrido * 1000) % 1000);

            textTela.text = $"{minutos:D2}:{segundos:D2}:{milissegundos:D3}";
        }
    }

    public void PausarCronometro()
    {
        cronometroAtivo = false;
        textTela.color = Color.green;
    }
}