using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEditor.Timeline;
using UnityEngine;


public class Eff : MonoBehaviour
{
    

        public Animator animator; // Ссылка на Animator компонент
    private bool isMoving = false; // Пример условия

    void Start()
    {
        animator = GetComponent<Animator>(); // Получаем Animator компонент
    }

    void Update()
    {
        // Пример: Запуск анимации при нажатии кнопки "A"
        if (Time.timeScale == 0f)
        {
            isMoving = !isMoving; // Переключаем состояние
            animator.SetBool("IsMoving", isMoving); // Устанавливаем параметр аниматора
        }
    }
}

