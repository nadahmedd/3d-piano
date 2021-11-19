using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewayforce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);


        if (Input.GetKey("right"))
        {
            rb.AddForce(sidewayforce * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0);

        }

    }
}
