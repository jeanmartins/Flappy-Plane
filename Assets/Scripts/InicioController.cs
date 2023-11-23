using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioController : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ChecarSeJogoDeveIniciar();
    }

    private static void ChecarSeJogoDeveIniciar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }
}
