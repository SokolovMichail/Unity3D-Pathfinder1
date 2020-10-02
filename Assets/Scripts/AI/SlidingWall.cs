using UnityEngine;

namespace AI
{
    public class SlidingWall : MonoBehaviour
    {
        private float current_rot = 0;
        void Update()
        {
            Vector2 playerInput;
            if ((Input.GetKey(KeyCode.W)) | (Input.GetKey(KeyCode.A)) | (Input.GetKey(KeyCode.S)) |
                (Input.GetKey(KeyCode.D)))
            {
                playerInput.x = Input.GetAxis("Horizontal");
                playerInput.y = Input.GetAxis("Vertical");
                Vector3 displacement = new Vector3(10 * playerInput.x, 0f, 10 * playerInput.y);
                transform.localPosition += displacement;
                
            }
            if ((Input.GetKey(KeyCode.Q)))
            {
                current_rot += 1;
                transform.rotation =  Quaternion.Euler(0f, current_rot, 0);
            }
            if ((Input.GetKey(KeyCode.E)))
            {
                current_rot += 1;
                transform.rotation =  Quaternion.Euler(0f, current_rot, 0);
            }
        }
    }
}