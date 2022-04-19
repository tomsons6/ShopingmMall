// --------------------------------------------------------------------------
// <summary>Rotates an object on a specified axis at a given speed.</summary>
// --------------------------------------------------------------------------


using UnityEngine;

namespace sergeyiwanski
{
    public class RotateArround : MonoBehaviour
    {
        [Tooltip("Rotational speed.")]
        public Vector3 rotation;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(rotation, Space.Self);
        }
    }
}