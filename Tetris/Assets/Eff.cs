using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEditor.Timeline;
using UnityEngine;


public class Eff : MonoBehaviour
{
    

        public Animator animator; // ������ �� Animator ���������
    private bool isMoving = false; // ������ �������

    void Start()
    {
        animator = GetComponent<Animator>(); // �������� Animator ���������
    }

    void Update()
    {
        // ������: ������ �������� ��� ������� ������ "A"
        if (Time.timeScale == 0f)
        {
            isMoving = !isMoving; // ����������� ���������
            animator.SetBool("IsMoving", isMoving); // ������������� �������� ���������
        }
    }
}

