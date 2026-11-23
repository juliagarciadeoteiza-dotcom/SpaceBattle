using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float tiempo = 0;
    [SerializeField] float intervalo = 3;
    [SerializeField] GameObject textoGameOver;


    bool gameOver = false;

    void Start()
    {
        
    }

    void Update()
    {

       

        if (gameOver)
        {
            return; 
        }
        
        tiempo += Time.deltaTime;

        if (tiempo > intervalo)
        {
            tiempo = 0;
            GameObject newEnemy = Instantiate(enemy);
            newEnemy.transform.position = new Vector3(Random.Range(-7f, 7f), 10, 0);
        }
       
    }

    public void GameOver()
    {

        gameOver = true; 
        textoGameOver.SetActive(true);


    }
}
