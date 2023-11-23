using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private GameController game;
    void Start()
    {
        Destroy(obstaculo, 5f);
        game = FindObjectOfType<GameController>();
    }

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * velocidade;
        velocidade = 4f + game.RetornaLevel();
    }
}
