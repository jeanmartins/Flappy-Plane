using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private Renderer fundo;
    private float xOffSet = 0f;
    private Vector2 posicaoTextura;
    private float velocidade = 0.1f;
    void Start()
    {
        fundo = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xOffSet += Time.deltaTime * velocidade;
        posicaoTextura.x = xOffSet;
        fundo.material.mainTextureOffset = posicaoTextura;
    }
}
