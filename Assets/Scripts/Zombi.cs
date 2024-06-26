using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombi : MonoBehaviour
{
    Animator animator;
    GameObject player;
    public float rangeDistance = 100.0f;
    public bool shouldStop = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var zombiPos = transform.position;
        var playerPos = player.transform.position;

        var offset = Mathf.Abs(playerPos.z - zombiPos.z);
        if(offset < rangeDistance)
        {
            Atack();
        }
    }

    void Atack()
    {
        animator.SetTrigger("Atack");
        Invoke("LoadGameOver", 2.0f);
    }

    void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            FallDown();
        }
    }

    void FallDown()
    {
        shouldStop = true;
        Invoke("DestriyZombi", 3.0f);
    }

    void DestroyZombi()
    {
        Destroy(gameObject);
    }
}
