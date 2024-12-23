using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = true;
        myRigidbody.useGravity = true;

    }
    private void Update()
    {
        if (Time.time > timeToWait)
        {
            //myMeshRenderer.enabled = false;
            //myRigidbody.useGravity = false;
        }
    }
}
