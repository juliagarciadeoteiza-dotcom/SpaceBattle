using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] private float t = 0;
    void Start()
    {
        
    }

    void Update()
    {
        t=t+ Time.deltaTime;
        if (t > 3)
        {
            t = 0;
            GameObject newEnemy = Instantiate(enemy);
            newEnemy.transform.position = new Vector3(Random.Range(-7f, 7f), 10, 0);
        }
    }
}
