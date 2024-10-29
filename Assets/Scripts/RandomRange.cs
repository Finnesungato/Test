using UnityEngine;

public class RandomRange : MonoBehaviour
{
    //CREO UN ARRAY DE TIPO GAMEOBJECT
    [SerializeField] Vector3 initPos = new Vector3(-5, 0, 0);
    //CREMOS UN VECTOR DE POSICION
    [SerializeField] GameObject[] myArray = new GameObject[7];
    void Start()
    {
        //print(myArray[0]);
        print(Random.Range(0, 10));

        //CREAMOS 7 ELEMENTOS EN BASE A UNA POSICION Y ROTACION DADAS
        for (int i = 0; i < myArray.Length; i++)
        {

            //RANDOM RANGE
            int r = Random.Range(0,myArray.Length);

            Instantiate(myArray[r], initPos, Quaternion.Euler(0,180,0));
            //LOS SEPARAMOS UNOS DE OTROS SUMANDO UN NUEVO VECTOR
            initPos += new Vector3(Random.Range(0,10), 0, 0);
        }
    }

    
    void Update()
    {
        
        
    }
}
