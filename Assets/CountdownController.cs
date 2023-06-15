using UnityEngine;
using TMPro;

public class CountdownController : MonoBehaviour
{
    public TMP_Text countdownText; // Referência ao componente TMP_Text
    public GameObject playerObject; // Referência ao objeto do jogador
    public GameObject targetObject; // Referência ao objeto de destino

    private bool counting = false;
    private float countdownTime = 5f; // Tempo da contagem regressiva
    private float currentTime = 0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCountdown();
        }

        if (counting)
        {
            currentTime += Time.deltaTime;

            // Atualizar o texto com a contagem progressiva
            if (countdownText != null)
            {
                countdownText.text = "Contagem: " + currentTime.ToString("0.00");
            }

            // Verificar se houve colisão do jogador com o objeto de destino
            if (playerObject != null && targetObject != null && HasPlayerCollisionWithTarget())
            {
                EndCountdown();
            }
        }
    }

    private void StartCountdown()
    {
        counting = true;
        currentTime = 0f;
        Debug.Log("Contagem progressiva iniciada!");

        // Resetar o texto para a contagem inicial
        if (countdownText != null)
        {
            countdownText.text = "Contagem: 0.00";
        }
    }

    private void EndCountdown()
    {
        counting = false;
        Debug.Log("Contagem progressiva concluída!");

        // Exibir a contagem final no componente de texto
        if (countdownText != null)
        {
            countdownText.text = "Contagem Final: " + currentTime.ToString("0.00");
        }
    }

    private bool HasPlayerCollisionWithTarget()
    {
        Collider playerCollider = playerObject.GetComponent<Collider>();
        Collider targetCollider = targetObject.GetComponent<Collider>();

        if (playerCollider != null && targetCollider != null)
        {
            return playerCollider.bounds.Intersects(targetCollider.bounds);
        }

        return false;
    }
}
