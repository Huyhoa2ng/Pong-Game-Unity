using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colli : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BounceFromBacket(Collider2D c)
    {
        Vector3 ballPosition  = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHight = c.GetComponent<Collider>().bound.size.y;

        float x;

        if (c.gameObject.name == "RacketPlayer1")
            x = 1;
        else
            x = -1;

        float y = (ballPosition.y - racketPosition.y) / racketHight;

        this.ballMovement.MoveBall(new Vector2(x, y));
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromBacket(collision);
        }else if(collision.gameObject.name == "Wallleft")
        {
            Debug.Log("Collision with wallLeft");
        }else if(collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collison with wallRight");
        }
    }



}
