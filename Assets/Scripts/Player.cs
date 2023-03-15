using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/*using UnityEngine.InputSystem;*/
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private int ScoreValue = 0;
    

    [SerializeField] private TMP_Text _scoreText;
    public delegate void MessageEvent();
    //public static event MessageEvent ObjetToucher;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _scoreText.text = "Score : " + ScoreValue;
    }

    void Update()
    {
        _scoreText.text = "Score : " + ScoreValue;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Plateau"))
        {
            Destroy(other.gameObject);
            //ObjetToucher.Invoke();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target") || (collision.gameObject.CompareTag("Plateau")))
        {
           
            Destroy(collision.gameObject, 3f);
            UpdateScore(collision);
            //ObjetToucher.Invoke();
        }
    }
    private void UpdateScore(Collision col)

    {
        if (col.gameObject.tag == "Target") // Si on touche un objet joyau , le score augmente de 1
        {

            ScoreValue++;
        }
     


    }

   
}

