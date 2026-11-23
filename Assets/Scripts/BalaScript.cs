using Unity.VisualScripting;
using UnityEngine;

public class BalaScript : MonoBehaviour
{
   
    [SerializeField] float velocidad = 10; 

    void Start()
    {
        
    }

    void Update()
    {
        
        transform.position += Vector3.up * velocidad * Time.deltaTime;


    }

    void OnTriggerEnter2D (Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {

            Destroy(collision.gameObject);
            Destroy(gameObject); 

        }


    }



}
