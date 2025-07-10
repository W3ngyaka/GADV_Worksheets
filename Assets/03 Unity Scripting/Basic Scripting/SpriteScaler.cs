using UnityEngine;
namespace GADVDataTypes
{
    public class SpriteScaler : MonoBehaviour
    {
        private Transform spriteTransform;
        private string scale = "2.0";
        void Start()
        {
            spriteTransform = GetComponent<Transform>();
            float scaleValue = float.Parse(scale);
            spriteTransform.localScale = new Vector3(scaleValue, scaleValue, 1f);
        }
    }
}
