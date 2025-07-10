using UnityEngine;

namespace GADVDataTypes
{
    public class SpriteMover : MonoBehaviour
    {
        private int moveSpeed = 3;
        private float timeElapsed = 2.5f;

        // Update is called once per frame
        void Update()
        {
            //Implicit conversion (int to float)
            float totalMovement = moveSpeed + timeElapsed;
            transform.position = new Vector3(totalMovement, 0, 0);

            //int roundedSpeed = totalMovement;

            //explicit conversion (truncates decimal)
            int roundedSpeed = (int)totalMovement;

           
        }
    }
}