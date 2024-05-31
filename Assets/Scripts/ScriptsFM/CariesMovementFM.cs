using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CariesMovementFM : MonoBehaviour
{
    public float speed = 4.0f;
    public float changeDirectionInterval = 3.0f; // Intervalo en segundos para cambiar de dirección
    public Vector3 movementBounds = new Vector3(10.0f, 10.0f, 10.0f); // Límites del movimiento en X, Y y Z

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
        // Generar una dirección aleatoria
        float randomAngleX = Random.Range(0, 360) * Mathf.Deg2Rad;
        float randomAngleY = Random.Range(0, 360) * Mathf.Deg2Rad;
        movementDirection = new Vector3(Mathf.Cos(randomAngleX), Mathf.Sin(randomAngleY), Mathf.Sin(randomAngleX)).normalized;
    }

    void Move()
    {
        // Calcular la nueva posición
        Vector3 newPosition = transform.position + movementDirection * speed * Time.deltaTime;

        // Verificar límites de movimiento
        if (Mathf.Abs(newPosition.x) > movementBounds.x || Mathf.Abs(newPosition.y) > movementBounds.y || Mathf.Abs(newPosition.z) > movementBounds.z)
        {
            // Invertir dirección si se alcanzan los límites
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