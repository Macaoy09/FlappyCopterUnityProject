using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float pipeDeadZone = -11;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // equation for Pipe Movement
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // conditional statement for PipeDeadZone
        if (transform.position.x <= pipeDeadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
