using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Move : MonoBehaviour {

    private bool _playerCollisioned;
    private bool _gravity;

    private GameObject winImg;
    private GameObject loseImg;
    private GameObject btnYes;
    private GameObject btnNo;
    private GameObject question;

    void Start() {
        _playerCollisioned = true;
        _gravity = true;
        winImg = GameObject.Find("Win");
        loseImg = GameObject.Find("Lose");
        btnYes = GameObject.Find("Yes");
        btnNo = GameObject.Find("No");
        question = GameObject.Find("Question");
        winImg.SetActive(false);
        loseImg.SetActive(false);
        btnYes.SetActive(false);
        btnNo.SetActive(false);
        question.SetActive(false);
    }

    void FixedUpdate() {

        CheckTouch();

        if (_gravity) {
            transform.Translate(new Vector3(1, -1, 0) * Time.deltaTime * 10f);
        }

        else {
            transform.Translate(new Vector3(1, 1, 0) * Time.deltaTime * 10f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground") {
            _playerCollisioned = true;
        }

        if (collision.gameObject.tag == "Finish")
        {
            winImg.SetActive(true);
            Destroy(gameObject);
            SetActiveButtons();
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        _playerCollisioned = false;
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Lose")
        {
            loseImg.SetActive(true);
            Destroy(gameObject);
        }
        SetActiveButtons();
    }

    void CheckTouch() {
        if (Input.touchCount > 0) {
            if (_playerCollisioned) {
                _gravity = (!_gravity);
                _playerCollisioned = false;
            }
        }
    }

    void SetActiveButtons() {
        question.SetActive(true);
        btnYes.SetActive(true);
        btnNo.SetActive(true);
    }

    //GetComponent<Rigidbody2D> ().AddForce ((Vector2.right * 5f));
    //transform.Translate(new Vector3(1,-1,0) * Time.deltaTime);
    //GetComponent<Rigidbody2D> ().AddForce (new Vector2((Input.acceleration.x * 5f), 0));
    //GetComponent<Rigidbody2D>().AddForce(Vector2.up, ForceMode2D.Impulse);
}
