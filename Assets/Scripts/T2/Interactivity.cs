using UnityEngine;

public class Interactivity : MonoBehaviour
{
    public float speed;
    public float rotSpeed;

    //ROTACION VIA CHECK FRAME 
    Vector3 lastframePos;
    Vector3 currentframePos;
    Quaternion lastframeRot;
    void Start()
    {
        lastframePos = currentframePos;
        lastframeRot = transform.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        float desplZ = Input.GetAxis("Vertical");



        float desplX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * desplX * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.right * rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.left * rotSpeed * Time.deltaTime);
        }

        //RESTRINGIR COORDENADAS 
        float PosZ = transform.position.z;

        if (PosZ > 100 || PosZ < -100)
        {
            transform.position = Vector3.zero;
        }
        else
        {
            transform.Translate(Vector3.forward * desplZ * Time.deltaTime * speed);
        }

        //ROTACION VIA CHECK FRAME 

        
    }
}
