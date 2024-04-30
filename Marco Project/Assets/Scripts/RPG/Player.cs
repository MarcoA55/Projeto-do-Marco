using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 2f;
    public float ManaInicial = 100f;
    public float taxaDeDecrementoMana = 1f;
    public float ManaAtual;
    private Rigidbody2D rb;
    public Slider SliderMana;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ManaAtual = ManaInicial;
    }
    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;

        rb.velocity = new Vector2(eixoX, eixoY);
        Debug.Log($"Horizontal: {eixoX}, Vertical: {eixoY}");
    }

    void AtualizarSliderMana()

    {
        SliderMana.value = ManaAtual / ManaInicial;
    }

}