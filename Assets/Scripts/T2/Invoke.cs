using System.Collections;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject myObject;
    void Start()
    {


        
        
    }

    

    private void SpawnObject()
    {
        Instantiate(myObject);  
    }
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Invoke(nameof(SpawnObject), 0);
            //InvokeRepeating(nameof(SpawnObject), 0);
        }
    }
}
