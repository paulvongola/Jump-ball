using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] private float jumpPower;

    [Range(0f, 10f)]
    [SerializeField] private float jumpDuration;

    private bool isStart = false;

    // récuperation de la pos du pouce 
    private Vector3 touchPosition;

    private bool isJumping = false;
    Sequence jumping;

    private void Update()
    {

        if (Input.touchCount > 0)
        {
            isStart = true;
            touchPosition = Input.GetTouch(0).position;
            touchPosition.z = 10f;
            touchPosition = Camera.main.ScreenToWorldPoint(touchPosition);

            transform.DOMoveX(touchPosition.x - transform.position.x, Time.deltaTime).SetRelative(true).From();
        }

        Jumping();

    }


    void Jumping()
    {
        if (isJumping || !isStart)
            return;
        isJumping = true;
        jumping = transform.DOJump(new Vector3(0, 0, 5f), jumpPower, 1, jumpDuration).SetEase(Ease.Linear).SetRelative(true);
        jumping.OnComplete(stateJump);
    }

    void stateJump()
    {
        isJumping = false;
    }
}
