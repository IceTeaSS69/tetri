using UnityEngine;

public class MoveNfall : MonoBehaviour
{
    public GameObject[] blocks;    // ������ �����
    public float fallSpeed = 3; // �������� �������

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomBlock();
           
        }
    }

    void SpawnRandomBlock()
    {
        // �������� ��������� ���� �� �������
        int randomIndex = Random.Range(0, blocks.Length);
        GameObject randomBlock = blocks[randomIndex];

        // ������� ���� � ����������� ������
        GameObject newBlock = Instantiate(randomBlock, transform.position, Quaternion.identity);
        newBlock.GetComponent<Rigidbody2D>().gravityScale = fallSpeed;
    }
}
