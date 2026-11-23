using Unity.VisualScripting;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] GameObject bala;  
    [SerializeField] Transform puntoDisparo;
    [SerializeField] float TiempoEntreDisparos = 0.3f;


    Rigidbody2D rb;
    float tiempoDisparo = 0; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }

        tiempoDisparo += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && tiempoDisparo >= TiempoEntreDisparos)
        {

            Instantiate(bala, puntoDisparo.position, Quaternion.identity);
            tiempoDisparo = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.transform.position = new Vector3(0,0,0);

            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0;

            Destroy(collision.gameObject);

        }
        if (collision.CompareTag("Enemy"))
        {

            GetComponent<SpriteRenderer>().color = Color.red;
            FindObjectOfType<GameController>().GameObject(); 


        }
    }

}
