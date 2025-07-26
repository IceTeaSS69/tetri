using UnityEngine;
using UnityEngine.UI;

public class GOmenu : MonoBehaviour
{


    private bool hasCollided = false;

    private void Start()
    {
        DestroySc.Endtouch = false;
        DestroySc.IsBlockTouched = false;
        DestroySc.maxcol = 0;
        hasCollided = false; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasCollided) return;

        if (collision.gameObject.CompareTag("Plate") || collision.gameObject.CompareTag("Block"))
        {
            DestroySc.maxcol++;
            if (DestroySc.maxcol > 0)
            {
                DestroySc.IsBlockTouched = true;
                DestroySc.maxcol = 0;
                hasCollided = true; 
            }
        }
        else if (collision.gameObject.CompareTag("End"))
        {   
            hasCollided = true;
            DestroySc.Endtouch = true;
            Time.timeScale = 0f;

        }
    }
}
