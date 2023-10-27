using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the pipe with frame rate independence.
        transform.position = transform.position + (Vector3.left * moveSpeed);
        if (transform.position.x < deadZone)
        {
            
            Destroy(gameObject);
            Debug.Log("pipe deleted");
        }
    }
}
