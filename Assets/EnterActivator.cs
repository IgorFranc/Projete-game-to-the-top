using UnityEngine;

public class EnterActivator : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objectsToActivate;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
        }
    }
}
