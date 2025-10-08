using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Este método se llama cuando otro objeto con un Collider2D entra en el trigger.
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificamos si el objeto que entró es el jugador (asegúrate de que tu pájaro tenga el tag "Player").
        if (other.CompareTag("Player"))
        {
            // Buscamos el script del jugador y activamos el power-up.
            FlappyBird bird = other.GetComponent<FlappyBird>();
            if (bird != null)
            {
                bird.ActivateInvincibility(5f); // Llama a la función para activar la invencibilidad por 5 segundos.
            }

            // Destruimos el objeto del power-up para que desaparezca.
            Destroy(gameObject);
        }
    }
}
