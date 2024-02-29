using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Player_Controller : MonoBehaviour
{
    #region Editor Data
    [Header("Movement Attributes")]
    [SerializeField] float moveSpeed = 50f;

    [Header("Dependies")]
    [SerializeField] Rigidbody2D rigidbody;
    #endregion

    #region Internal Data
    private Vector2 movDirection = Vector2.zero;
    #endregion

    #region Tick
    private void Update()
    {
        GatherInput();
    }

    private void FixedUpdate()
    {
        MovementUpdate();
    }
    #endregion


    #region Input Logic
    private void GatherInput()
    {
        movDirection.x = Input.GetAxisRaw("Horizontal");
        movDirection.y = Input.GetAxisRaw("Vertical");

        print(movDirection);
    }
    #endregion

    #region Movement Logic
    private void MovementUpdate()
    {
        rigidbody.velocity = movDirection * moveSpeed * Time.fixedDeltaTime;
    }
    #endregion
}
