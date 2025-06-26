using UnityEngine;

public class MoveNfall : MonoBehaviour
{
    public GameObject[] blocks;
    public float fallSpeed = 3; 

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomBlock();
           
        }
    }

    void SpawnRandomBlock()
    {
        // Выбираем случайный блок из массива
        int randomIndex = Random.Range(0, blocks.Length);
        GameObject randomBlock = blocks[randomIndex];

        // Создаем блок и настраиваем физику
        GameObject newBlock = Instantiate(randomBlock, transform.position, Quaternion.identity);
        newBlock.GetComponent<Rigidbody2D>().gravityScale = fallSpeed;
    }
}
