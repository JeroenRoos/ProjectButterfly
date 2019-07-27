using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const int _coinScore = 10;

    // Start is called before the first frame update
    public CharacterController2D controller;
    public float runSpeed = 20f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    bool touchesScreen = false;

    public ScoringController scoringController;

    // Update is called once per frame
    void Update()
    {
        scoringController.UpdateScoreOnMovement(Mathf.RoundToInt(GetPlayerPosition()));

        //horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        horizontalMove = runSpeed;

        if (Input.touchCount > 0 && touchesScreen == false)
        {
            jump = true;
            touchesScreen = true;
        }

        if (Input.touchCount == 0)
        {
            touchesScreen = false;
            Debug.Log(Input.touchCount);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        //PlayerCamera.transform. = new Vector3(horizontalMove, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            // Do something
        }
        else if (collision.gameObject.tag == "Coins")
        {
            scoringController.UpdateScoreOnCoin(_coinScore);
            Destroy(collision.gameObject);
        }
    }

    private float GetPlayerPosition()
    {
        return this.transform.position.x;
    }
}