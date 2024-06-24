using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject spawnArea;
    public GameObject basicEnemy;
    public float timeToSpawn;
    float minHeight;
    float maxHeight;    

   public float count;

    // Start is called before the first frame update
    void Start()
    {

            GenerateEnemy();
            timeToSpawn = 2;
            count = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        

        if(count > 0) {
            count -= Time.deltaTime;

        }
        else {
            GenerateEnemy();
            count = timeToSpawn;
        }

    }

    public void GenerateEnemy() {
                GameObject newEnemy = Instantiate(basicEnemy);
        newEnemy.transform.position = spawnArea.transform.position + new Vector3(0, Random.Range(-3, 4), 0);
    }
}
