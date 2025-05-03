using UnityEngine;

public class HelixController : MonoBehaviour
{
    private Vector2 lastTapPosition;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.localEulerAngles;
        lastTapPosition = Vector2.zero; // Inicializa lastTapPosition aquí
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // Detecta el clic izquierdo del mouse
        {
            Vector2 currentTapPosition = Input.mousePosition;

            if (lastTapPosition == Vector2.zero)
            {
                lastTapPosition = currentTapPosition; // Guarda la posición inicial del clic
            }

            float distance = lastTapPosition.x - currentTapPosition.x; // Calcula la distancia del movimiento
            lastTapPosition = currentTapPosition; // Actualiza la última posición

            transform.Rotate(Vector3.up * distance); // Rota el objeto
        }
        else
        {
            lastTapPosition = Vector2.zero; // Reinicia lastTapPosition solo si no se está haciendo clic
        }
    }
}
