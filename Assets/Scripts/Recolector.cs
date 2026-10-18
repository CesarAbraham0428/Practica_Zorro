using UnityEngine;
 
[RequireComponent(typeof(Collider2D))]
public class Recolector : MonoBehaviour
{
    public PuntajeJuego marcador;
    private bool recogido;
 
    private void Awake()
    {
        if (marcador == null)
            marcador = FindFirstObjectByType<PuntajeJuego>();
    }

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (recogido || !otro.CompareTag("Player")) return;

        bool esFrutaDulce = CompareTag("Dulce");
        if (!esFrutaDulce && !CompareTag("Agria")) return;

        recogido = true;
        if (marcador == null)
        {
            Debug.LogError("Asigna GameManager al campo Marcador.", this);
        }
        else
        {
            marcador.Registrar(esFrutaDulce ? 10 : -5, esFrutaDulce);
        }

        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
