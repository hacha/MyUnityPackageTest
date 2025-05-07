using UnityEngine;

namespace SimpleUnityPackageSample
{
    public class Rotator : MonoBehaviour
    {
        // インスペクターで調整可能な回転スピード（各軸ごと）
        public Vector3 rotationSpeed = new Vector3(0f, 90f, 0f);

        void Update()
        {
            // deltaTime を使ってフレームレートに依存しない回転にする
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }
}