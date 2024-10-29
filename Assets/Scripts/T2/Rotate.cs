using Unity.Collections;
using UnityEngine;

public class Controles : MonoBehaviour
{

    public float speed;
    [SerializeField] GameObject objeto;
    public float Pitch;
    public float Yaw;
    public float Roll;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float PosZ = objeto.transform.position.z;




        objeto.transform.Translate(Vector3.forward * -speed);




        transform.Rotate(Vector3.right * Time.deltaTime * Pitch);
        transform.Rotate(Vector3.up * Time.deltaTime * Yaw);
        transform.Rotate(Vector3.forward * Time.deltaTime * Roll);

    }
}