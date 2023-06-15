using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject[] SpawnItens;
    public float spawntime;
    public float spawndelay;
    public float tempoDeDesaparecimento; // Tempo em segundos antes do objeto desaparecer

    private void Start()
    {
        StartCoroutine(SpawnRandomWithDelay());
    }

    IEnumerator SpawnRandomWithDelay()
    {
        while (true)
        {
            SpawnRandom();
            yield return new WaitForSeconds(spawndelay);
        }
    }

    void SpawnRandom()
    {
        GameObject spawnedItem = Instantiate(SpawnItens[Random.Range(0, SpawnItens.Length)], transform.position, Quaternion.identity);
        StartCoroutine(Desaparecer(spawnedItem));
    }

    IEnumerator Desaparecer(GameObject objeto)
    {
        yield return new WaitForSeconds(tempoDeDesaparecimento);
        Destroy(objeto);
    }
}
