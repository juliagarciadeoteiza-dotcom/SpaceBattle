using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    [SerializeField] float velocidad = 2;
    [SerializeField] float aumentoV = 0.1f;


    void Start()
    {
        
    }

    void Update()
    {
        velocidad += aumentoV * Time.deltaTime;
        transform.position += Vector3.down * velocidad * Time.deltaTime; 
    }
}
