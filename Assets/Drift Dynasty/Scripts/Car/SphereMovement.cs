using UnityEngine;
using UnityEngine.InputSystem;

namespace Phyw.Car
{

  public class SphereMovement : MonoBehaviour
  {
    #region Variables
    [SerializeField] private Rigidbody sphere;
    [SerializeField] Transform car;
    [SerializeField] Transform normal;
    [SerializeField] private float rotSpeed = 1.0f;
    [SerializeField] private float lerpSpeed = 1.0f;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] LayerMask maskGround;

    private Vector3 offset;
    private Vector2 vec;
    private RaycastHit hit;

    //private bool isPressingMove;
    #endregion

    private void Start()
    {
      offset = new Vector3(0, 0.6f, 0);
      //sphere.maxLinearVelocity = 100;
    }

    #region UnityMethods


    private void FixedUpdate()
    {
      // Gravity
      sphere.AddForce(Vector3.down * 30, ForceMode.Acceleration);

      Vector3 start = car.position;
      Physics.Raycast(start, Vector3.down, out hit, 1, maskGround);
      if (hit.collider)
      {
        //Check if grounded then add full force
        normal.up = Vector3.Lerp(normal.up, hit.normal, lerpSpeed);
        //normal.up = hit.normal;
        //normal.Rotate(0, transform.eulerAngles.y, 0);

        int speedMul = (hit.collider.tag == "Mud") ? 60 : 100;
        sphere.AddForce(car.transform.forward * vec.y * speedMul * speed, ForceMode.Acceleration);
      }
      car.Rotate(0, vec.x * rotSpeed, 0);
      car.position = sphere.position - offset;
    }
    #endregion

    #region CustomMethods

    public void Move(InputAction.CallbackContext ctx)
    {

      //if (ctx.phase == InputActionPhase.Started)
      //{
      //  isPressingMove = true;
      //}
      //else if (ctx.phase == InputActionPhase.Canceled)
      //{
      //  isPressingMove = false;
      //}
      vec = ctx.ReadValue<Vector2>();
    }
    #endregion

  }
}


/*

  * Sphere will handle collisions
    
  * Detect the normal postion to get the car forward
    car.up = normal 
 * Move towards the car forward
    sphere.addForce(car.forward) 
*/