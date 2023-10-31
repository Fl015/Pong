using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 5f;
    public float ySpeed = 5f;
    public TMP_Text scoreText;
    public int leftScore = 0;
    public int rightScore = 0;
    public int winScore = 7;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        // xPosition += xSpeed * Time.deltaTime; shorter way to do the same thing
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
        if(leftScore >= winScore)
        {   
            scoreText.text = "Left player has won!";
            xPosition = 0f;
            yPosition = 0f;
        }
        else if(rightScore >= winScore)
        {
            scoreText.text = "Right player has won!";
            xPosition = 0f;
            yPosition = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalR"))
        {
            xPosition = 0f;
            yPosition = 0f;
            xSpeed = xSpeed * -1f;
            leftScore++;
            scoreText.text = leftScore + " | " + rightScore;

        }
        else if (collision.gameObject.CompareTag("verticalL"))
        {
            xPosition = 0f;
            yPosition = 0f;
            xSpeed = xSpeed * -1f;
            rightScore++;
            scoreText.text = leftScore + " | " + rightScore;
        }
        else if (collision.gameObject.CompareTag("Paddle"))
        {
            xSpeed = xSpeed * -1f;
        }
    }



}