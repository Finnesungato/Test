using UnityEngine;

public class IsOnGround : MonoBehaviour
{
    //IS GROUNDED PERMITE QUE SOLO SALTE AL TOCAR EL SUELO
    public bool IsGround = true;

    private Rigidbody rb;
    public float jumpForce;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Space)&& IsGround)
        {
            rb.AddForce(Vector3.up *jumpForce, ForceMode.Impulse);
            IsGround = false;
        }
        
        //print("Update time" + Time.deltaTime);
    }

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGround = true;
        }
        
    }
}
