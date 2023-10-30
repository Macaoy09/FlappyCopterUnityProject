using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopterScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flightStrength;
    public LogicManagerScript logic;
    public bool copterIsActive = true;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && copterIsActive == true)
        {
            myRigidbody2D.velocity = Vector2.up * flightStrength;
        }

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        logic.gameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        copterIsActive = false;
    }
}
