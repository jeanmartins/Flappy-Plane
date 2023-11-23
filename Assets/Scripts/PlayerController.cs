using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D aviaoRB;
    [SerializeField] private float velocidade = 5f;
    void Start()
    {
        this.aviaoRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Subir();
        LimitarVelocidade();
        ChecarSeSaiuDoLimiteDoJogo();
    }

    private void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.aviaoRB.velocity = Vector2.up * velocidade;
        }
    }

    private void LimitarVelocidade()
    {
        if (this.aviaoRB.velocity.y < -velocidade)
        {
            this.aviaoRB.velocity = Vector2.down * velocidade;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    }

    private void ChecarSeSaiuDoLimiteDoJogo()
    {
        if(transform.position.y > 5.5f || aviaoRB.position.y < -5.5f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
