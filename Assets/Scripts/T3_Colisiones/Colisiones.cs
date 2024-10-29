using UnityEngine;

public class Colisiones : MonoBehaviour
{

    public MeshRenderer myMesh2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {
            myMesh2.enabled = false;

            //VELOCIDAD DE COLISION , COSA EXTRA
            print("Cubo 1 eliminado");
        }
        if (collision.gameObject.tag == "Cubomalo")
        {
            myMesh2.enabled = false;
            print("Cubo 2 eliminado");
        }
    }
}
