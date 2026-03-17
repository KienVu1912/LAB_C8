using UnityEngine;

public class EnemySqawer : MonoBehaviour
{
     public GameObject enemyPrefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
