using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    private bool isShoot;

    private Vector3 startPos;

     public AudioSource canSnd;
     public AudioSource ballSnd;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        startPos = transform.position;
    }

    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        Shoot(mouseReleasePos-mousePressDownPos);
    }

    private float forceMultiplier = 3;
    void Shoot(Vector3 Force)
    {
        if(isShoot)  
            return;

        rb.AddForce(new Vector3(Force.x,Force.y,Force.z) * forceMultiplier);
        isShoot = true;
        ballSnd.Play();  
        Spawner.Instance.NewSpawnRequest();
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Can") {
            canSnd.Play();
            Destroy(gameObject, 0.5f);
        }
    }

}
