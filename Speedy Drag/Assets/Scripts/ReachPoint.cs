using UnityEngine;

public class ReachPoint : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            gameManager.IsWin();
        }
    }
}
