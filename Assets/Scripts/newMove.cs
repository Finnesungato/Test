
using UnityEngine;


public class newMove : MonoBehaviour
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

        //MOVER EL CUBO SEG�N LAS FLECHAS UTILIZANDO FUERZA

        float desplX = Input.GetAxis("Horizontal");
        rb.AddForce(desplX*Vector3.forward * force, ForceMode.Acceleration);
        //float forceY = Input.GetAxis("Vertical");
        //rb.AddForce(Vector3.right * forceY * forceRight);

        //float forceZ = Input.GetAxis("Vertical");
        // rb.AddForce(Vector3.left * forceZ * forceRight);

        //HACER SALTAR EL CUBO CON LA BARRA ESPACIADORA

        
            /*rb.mass = 0;
            rb.AddForce(Vector3.down  * jumpForce);
            rb.linearVelocity.x = 0; */
        


        //APLICAR TORSION 
        //rb.AddTorque(torsionX, 0, 0);

        //UTILIZAMOS LAS FLECHAS IZQUIERDA Y DERECHA PARA TORSIONARLO
    }
}
