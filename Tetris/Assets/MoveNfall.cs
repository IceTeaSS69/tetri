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

    private void Start()
    {
        StartSpawn();
    }

    public void StartSpawn()
    {
        if (current == 9)
        {
            current = 0;

        }

       
        current = (current + 1) % blocks.Length;
        blockInt++;

        
        blocks[current] = Instantiate(blocks[current], SpaPosition, Quaternion.identity);
    }

    public void Spawn()
    {
        if (DestroySc.IsBlockTouched == true)
        {
            StartSpawn();
        }

       
    }

    private void Update()
    {
        Spawn();
        if(blockInt > maxBl)
        {
            Time.timeScale = 0f;
        }
        float moveInput = Input.GetAxis("Horizontal");
        if (Time.timeScale == 1f)
        {
            blocks[current].transform.position += new Vector3(moveInput * speed, 0, 0);
        }
        else if (Time.timeScale == 0f)
        {
            Debug.Log("Game Paused");
        }

        if (Input.GetKeyDown(KeyCode.R) && Time.timeScale == 1f)
        {
            blocks[current].transform.Rotate(0, 0, 90);
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
    }

}
