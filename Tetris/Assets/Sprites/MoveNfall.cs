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
    public float speed = 1f;
   
    private void Awake()
    {
        StartSpawn();
    }

    void StartSpawn()
    {
        current = (current + 1) % blocks.Length;
        blockInt++;
        blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
    }
    public void Spawn()


    {
        if (DestroySc.IsBlockTouched == true)
        {
            current = (current + 1) % blocks.Length;
            blockInt++;
            blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
        }
        if(DestroySc.Endtouch == true)
        {
            Time.timeScale = 0f;
        }
        
    }
    
    
    public void Update()
    {
        Spawn();

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
                Spawn();
            }
            if (Time.timeScale == 0f)
            {
                Debug.Log("Error");
            }
                               
        }
        float moveInput = Input.GetAxis("Horizontal");

        if (Time.timeScale == 1f)
        {
            blocks[current].transform.position += new Vector3(moveInput * speed, 0, 0);
        }
        else if (Time.timeScale == 0f)
        {
            Debug.Log("Error");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            if (Time.timeScale == 1f)
            {
                blocks[current].transform.Rotate(0, 0, 90);
            }
            if (Time.timeScale == 0f)
            {
                Debug.Log("Error");
            }
            
        }

    }

}
