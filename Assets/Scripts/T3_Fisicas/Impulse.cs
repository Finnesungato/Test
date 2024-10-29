using UnityEngine;

public class Impulse : MonoBehaviour
{
    [SerializeField] float force;
    [SerializeField] float forceRight;
    public float jumpForce;
    private Rigidbody rb;

    public float torsionX;
    void Start()
    {
        //ME COJO EL RIGIDBODY 
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //APLICAR UNA FUERZA
        //rb.AddForce(Vector3.up * force);

        //MOVER EL CUBO SEG?N LAS FLECHAS UTILIZANDO FUERZA

        float forceX = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * forceX * forceRight);

        //HACER SALTAR EL CUBO CON LA BARRA ESPACIADORA

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
        else
        {
            /*rb.mass = 0;
            rb.AddForce(Vector3.down  * jumpForce);
            rb.linearVelocity.x = 0; */
        }

        //APLICAR TORSION 
        rb.AddTorque(torsionX, 0, 0);

        //UTILIZAMOS LAS FLECHAS IZQUIERDA Y DERECHA PARA TORSIONARLO
    }
}
