using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Variaveis e tipos de dados
        int pontos = 10;
        float peso = 61.8f;
        double medida = 9.99999999999;
        bool ativado = false;//true
        string saudacao = "Olá tudo bem";


        Debug.Log("inteiro:" + pontos);
        Debug.Log("peso:" + peso);
        Debug.Log("medida" + medida);
        Debug.Log("booleana" + ativado);
        Debug.Log("string" + saudacao);

        //operadores aritimeticos
        int soma = 2 + 2;
        int subtracao = 10 - 2;
        int multiplicacao = 2 * 3;
        float divisao = 10f / 3f;
        int resto = 10 % 3;

        Debug.Log("Soma:" + soma);
        Debug.Log("Subtração:" + subtracao);
        Debug.Log("Multiplicação:" + multiplicacao);
        Debug.Log("Divisão:" + divisao);
        Debug.Log("Resto:" + resto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
