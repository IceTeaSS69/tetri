using UnityEngine;

public class Spawn : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = gameObject.transform.position - new Vector3(0.01f, 0, 0);
        }
        
    }
}
