using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject[] selectedObjects; // Objetos selecionados que aplicarão a condição de colisão com o jogador

    private Vector3 targetPosition = new Vector3(-322.73f, 70.29f, 9.38f); // Posição desejada

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Verifica se o objeto que colidiu está na lista de objetos selecionados
            if (IsSelectedObject(collision.gameObject))
            {
                // Condição quando o objeto colide com o jogador
                Debug.Log("Objeto colidiu com o jogador!");

                // Move o objeto para a posição desejada
                collision.gameObject.transform.position = targetPosition;
            }
        }
    }

    private bool IsSelectedObject(GameObject gameObject)
    {
        // Verifica se o objeto está na lista de objetos selecionados
        for (int i = 0; i < selectedObjects.Length; i++)
        {
            if (gameObject == selectedObjects[i])
            {
                return true;
            }
        }
        return false;
    }
}
