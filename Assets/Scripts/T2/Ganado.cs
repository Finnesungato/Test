using TMPro;
using UnityEngine;

public class Ganado : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI myText1;
    [SerializeField] MeshRenderer Sphere;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            myText1.text = "¡Enhorabuena!";
            Debug.Log(this.gameObject);
        }
    }
}
