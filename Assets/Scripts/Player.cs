using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    [SerializeField]
    public Stat health;


    private void Awake()
    {

        health.Initialize();

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            health.CurrentVal -= 10;
            Debug.Log("hits");

        }

        if (health.CurrentVal <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Player Destroyed");
            SceneManager.LoadScene("Lose");


        }

    }


private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight){
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
             
        } else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight){
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
           

        }
    }










}
