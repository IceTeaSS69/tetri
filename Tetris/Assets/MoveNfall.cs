using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MoveNfall : MonoBehaviour
{
    
    public int current = 0;
    public Text score;
    public Text Record;
    public GameObject[] blocks;
    public float fallSpeed = 3;
    public Vector3 SpaPosition;
    public int maxBl = 10;
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

        if (Time.timeScale == 0f)
        {
            Destroy(score);
            Record.text = $"Your RECORD = {blockInt}";
        }
        if (blockInt > maxBl)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale == 1f)
            {
                current = (current + 1) % blocks.Length;
                blockInt++;
                blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
            }
            if (Time.timeScale == 0f)
            {
                Debug.Log("Error");
            }
                               
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Time.timeScale == 1f)
            {
               blocks[current].transform.position += new Vector3(0.01f, 0, 0); 
            }
            if (Time.timeScale == 0f)
            {
                Debug.Log("Error");
            }
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Time.timeScale == 1f)
            {
                blocks[current].transform.position -= new Vector3(0.01f, 0, 0);
            }
            if (Time.timeScale == 0f)
            {
                Debug.Log("Error");
            }
            
        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            if (Time.timeScale == 1f)
            {
                
            }
            if (Time.timeScale == 0f)
            {
                Debug.Log("Error");
            }
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
      
}
