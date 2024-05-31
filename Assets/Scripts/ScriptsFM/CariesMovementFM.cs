using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CariesMovementFM : MonoBehaviour
{
    public float speed = 4.0f;
    public float changeDirectionInterval = 3.0f; // Intervalo en segundos para cambiar de direcci�n
    public Vector3 movementBounds = new Vector3(10.0f, 10.0f, 10.0f); // L�mites del movimiento en X, Y y Z

    private float timer;
    private Vector3 movementDirection;

    void Start()
    {
        ChangeDirection();
        timer = changeDirectionInterval;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeDirectionInterval)
        {
            ChangeDirection();
            timer = 0;
        }

        Move();
    }

    void ChangeDirection()
    {
        // Generar una direcci�n aleatoria
        float randomAngleX = Random.Range(0, 360) * Mathf.Deg2Rad;
        float randomAngleY = Random.Range(0, 360) * Mathf.Deg2Rad;
        movementDirection = new Vector3(Mathf.Cos(randomAngleX), Mathf.Sin(randomAngleY), Mathf.Sin(randomAngleX)).normalized;
    }

    void Move()
    {
        // Calcular la nueva posici�n
        Vector3 newPosition = transform.position + movementDirection * speed * Time.deltaTime;

        // Verificar l�mites de movimiento
        if (Mathf.Abs(newPosition.x) > movementBounds.x || Mathf.Abs(newPosition.y) > movementBounds.y || Mathf.Abs(newPosition.z) > movementBounds.z)
        {
            // Invertir direcci�n si se alcanzan los l�mites
            movementDirection = -movementDirection;
        }
        else
        {
            transform.position = newPosition;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PacMan"))
        {
            GameManagerFM.instance.GameOver();
        }
    }
}