using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private Vector3 posicao;
    [SerializeField] private float timer = 1f;
    [SerializeField] private float posMin = -0.3f;
    [SerializeField] private float posMax = 2.4f;
    [SerializeField] private float timerMin = 1f;
    [SerializeField] private float timerMax = 3;
    [SerializeField] private Text pontosTexto;
    [SerializeField] private Text levelTexto;
    private float pontos = 0f;
    private int level = 1;
    [SerializeField] private float proximoLevel = 7f;

    void Start()
    {

    }

    void Update()
    {
        GerarPontos();
        CriarObstaculo();
        GanhaLevel();
    }

    public int RetornaLevel()
    {
        return level;
    }

    private void GanhaLevel()
    {
        levelTexto.text = "Level: " + level;
        if (pontos > proximoLevel)
        {
            level++;
            proximoLevel *= 2;
        }
    }

    private void CriarObstaculo()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = Random.Range(timerMin / level, timerMax);
            posicao.y = Random.Range(posMin, posMax);
            Instantiate(obstaculo, posicao, Quaternion.identity);

        }
    }

    private void GerarPontos()
    {
        pontos += Time.deltaTime;
        pontosTexto.text = "Pontos: " + Mathf.Round(pontos).ToString();
    }
}
