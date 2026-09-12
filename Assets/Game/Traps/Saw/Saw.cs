using UnityEngine;

public class Saw : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");   
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);
        if (collision.gameObject.tag == player.tag)
        {
            GameManager.Instance.LooseLife();
        }
    }
}
