using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MoveNfall : MonoBehaviour
{
    public int current = 0;
    public Text score;
    public GameObject[] blocks;
    public float fallSpeed = 3;
    public Vector3 SpaPosition;
    int maxBl = 10;
    int blockInt = 0;
    private void Start()
    {
        current = (current + 1) % blocks.Length;
        blockInt++;
        blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
    }
    public void Update()
    {
        score.text = $"{blockInt}";
        if (blockInt > maxBl)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            current = (current + 1) % blocks.Length;
            blockInt++;
            blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);                    
        }
        if (Input.GetKey(KeyCode.D))
        {
            blocks[current].transform.position += new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            blocks[current].transform.position -= new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            blocks[current].transform.Rotate(0, 0, 90);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plate"))
        {
            current = (current + 1) % blocks.Length;
            blockInt++;
            blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Plate"))
        {
            current = (current + 1) % blocks.Length;
            blockInt++;
            blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
        }
    }

    void SpawnRandomBlock()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    current = (current + 1) % blocks.Length;
        //    int randomIndex = Random.Range(0, blocks.Length);
        //GameObject randomBlock = blocks[randomIndex];

        //// Создаем блок и настраиваем физику
        //GameObject newBlock = Instantiate(randomBlock, transform.position, Quaternion.identity);
        //newBlock.GetComponent<Rigidbody2D>().gravityScale = fallSpeed;
        //}
        // Выбираем случайный блок из массива
        
        
    }


}
