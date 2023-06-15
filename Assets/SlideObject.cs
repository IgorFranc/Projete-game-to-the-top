using UnityEngine;

public class SlideObject : MonoBehaviour
{
    public float slideSpeed = 10f;

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.down * slideSpeed;
    }
}
