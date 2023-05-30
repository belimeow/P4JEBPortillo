using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadGuyScript : MonoBehaviour
{
    public GameObject[] enemies;

    public int maxHealth;
    public int curHealth;
    private Animator myAnimator;
    private bool isDead;
    [SerializeField]
    private float DespawnTime = 2.5f;
    [SerializeField]
    private string DeathAnimHash = "isDead";

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myAnimator.enabled = true;
        myAnimator.SetBool(DeathAnimHash, isDead);


        maxHealth = 1;
        curHealth = maxHealth;



    }
    void Update()
    {
        if (curHealth < 1)
        {
            isDead = true;
            myAnimator.SetBool(DeathAnimHash, isDead);
            Destroy(gameObject, DespawnTime);
        }
        enemies = GameObject.FindGameObjectsWithTag("enemy"); // Checks if enemies are available with tag "Enemy". 
        if (enemies.Length == 0)
        {
            SceneManager.LoadScene("SucessScene"); // Load the scene with name "SucessScene"
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (isDead)
            return;
        if (col.tag == "bullet")
        {
            curHealth -= 1;
            Destroy(col.gameObject);
        }
    }
}

