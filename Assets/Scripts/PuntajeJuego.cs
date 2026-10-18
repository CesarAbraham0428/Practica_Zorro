using UnityEngine;

public class PuntajeJuego : MonoBehaviour
{
    public int totalFrutas = 8;
    public int Puntaje { get; private set; }
    public int FrutasRecogidas { get; private set; }

    private void Start()
    {
        Debug.Log("Puntaje actual: " + Puntaje);
    }
    public void Registrar(int puntos, bool esFruta)
    {
        Puntaje += puntos;
        if (esFruta) FrutasRecogidas++;
        Debug.Log("Puntaje actual: " + Puntaje);
    }
}