using UnityEngine;

public class EsferaCollider : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObject2;

    
    //VARIABLE TAG
    public string myTag = "";

    //MESH RENDERER
    [SerializeField] MeshRenderer myMesh;

    private void OnCollisionEnter(Collision other)
    {

        //Destroy(this.gameObject);
        //ESTO ES PARA DESTRUIR EL OTRO OBJETO
        Destroy(other.gameObject);
        //DESTRUIR OBJETO CONCRETO
        //Destroy(Sphere); 
        //DESTRUIR OBJETO VÍA NOMBRE

        /*if (other.gameObject.name == "Sphere")
        {
            Destroy(other.gameObject); 
        }*/

        //DESTRUIR OBJETO VÍA TAG

        //if (other.gameObject.tag == "Obstaculo")
        //{
        //DESTRUIR
        //Destroy(other.gameObject);

        //INVISIBILIZAR
        //  myMesh.enabled = false;
        //}

        /*if (other.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(other.gameObject);
        }
 
        if (other.gameObject.CompareTag(myTag))
        {
            Destroy(other.gameObject);
        }
 
 
        Debug.Log("Chocaste pendejo");
        } */
        Debug.Log(gameObject2.name);


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}