using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MoveNfall : MonoBehaviour
{
    [Header("Components")]

    [SerializeField] public Text score;
    [SerializeField] public Text Record;
    [SerializeField] public GameObject[] blocks;
    [SerializeField] public int current = 0;
    [Header("Settings")]
    [SerializeField] public float fallSpeed = 3;
    [SerializeField] public Vector3 SpaPosition;
    [SerializeField] public int maxBl = 10;
    [SerializeField] int blockInt = 0;
    [SerializeField] public float speed = 1f;
    public int SpawnRage = 1;
    
   
    private void Start()
    {
        Spawn();
        
    }

    private void Spawn()
    {   
        blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
        current = (current + 1) % blocks.Length;
        blockInt++;
        
    }
    
    
    
    private void Update()
    {
        if (DestroySc.IsBlockTouched == true)
        {
            Spawn();
        }
        else if (DestroySc.IsPlateTouched == true)
        {
            Spawn();
        }
        score.text = $"{blockInt}";
        
        if (Time.timeScale == 0f)
        {
            Destroy(score);
            Record.text = $"Your RECORD = {blockInt}";
        }
        else if (blockInt > maxBl)
        {
            Destroy(gameObject);

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
            else if (Time.timeScale == 0f)
            {
                Debug.Log("Error");
            }

        }

        
    }
    
}
