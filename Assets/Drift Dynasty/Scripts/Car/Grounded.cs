using UnityEngine;

namespace Phyw.Car
{

  public class Grounded : MonoBehaviour
  {
    #region Variables
    [SerializeField] float distance = 0.4f;
    Transform curr;
    RaycastHit hit;
    #endregion

    #region UnityMethods

    private void Start()
    {
      curr = transform;
    }

    public bool GetGrounded()
    {

      return Physics.Raycast(transform.position, Vector3.down, distance);

    }
    #endregion

    #region CustomMethods

    #endregion

  }
}