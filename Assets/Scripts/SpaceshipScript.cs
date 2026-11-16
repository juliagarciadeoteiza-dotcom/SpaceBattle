using Unity.VisualScripting;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject bala;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();




    }

    void Update()
    {
      
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }

        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.transform.position = new Vector3(0,0,0);

            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0;

            Destroy(collision.gameObject);

        }
    }

}
