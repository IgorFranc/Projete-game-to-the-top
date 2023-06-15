using UnityEngine;

public class DesaparecerObjeto : MonoBehaviour
{
    // Referência para o objeto que será desaparecido
    public GameObject objetoDesaparecer;

    private void Update()
    {
        // Verifica se a tecla "Enter" foi pressionada
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Desativa o objeto para fazê-lo desaparecer
            objetoDesaparecer.SetActive(false);
        }
    }
}
