using UnityEngine;

public class LookAt : MonoBehaviour
{
    //LLAMAR A LA ESFERA
    [SerializeField] Transform objetoMira;
    void Start()
    {
        
    }

    
    void Update()
    {
        //ACCION DE MIRAR HACIA UN PUNTO O COORDENADA
        transform.LookAt(objetoMira);
    }
}
