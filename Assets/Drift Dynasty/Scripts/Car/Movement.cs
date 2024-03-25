using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Phyw.Car
{

  public class Movement : NetworkBehaviour
  {
    #region Variables
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 5;
    [SerializeField] private float rotSpeed = 5;

    [SerializeField] private Grounded grounded;

    private Vector2 vec;
    private bool isPressingMove;
    #endregion

    #region UnityMethods

    private void OnEnable()
    {
      if (!IsOwner) enabled = false;
    }

    private void Update()
    {
      if (isPressingMove)
      {
        // Check if grounded then add full force 
        if (grounded.GetGrounded())
        {
          rb.AddForce(transform.forward * vec.y * Time.deltaTime * 100 * speed);
        }
        transform.Rotate(0, vec.x * rotSpeed * Time.deltaTime, 0);
      }
    }

    #endregion

    #region CustomMethods

    public void Move(InputAction.CallbackContext ctx)
    {

      if (ctx.phase == InputActionPhase.Started)
      {
        isPressingMove = true;
      }
      else if (ctx.phase == InputActionPhase.Canceled)
      {
        isPressingMove = false;
      }
      vec = ctx.ReadValue<Vector2>();
    }
    #endregion

  }
}