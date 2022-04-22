using UnityEngine;
using RayFire;

namespace Finished.Scripts
{
    public class Grenade : MonoBehaviour
    {
        public RayfireRigid grenade; // 手榴弹对象
        public Bomb bomb; // 炸弹脚本
        public float fuseTime; // 引信时间（秒）

        private void DebugIgnite()
        {
            print("[Debug] Ignite a grenade!");
            Ignite();
        }

        private void Ignite()
        {
            grenade.Initialize();
            grenade.Demolish();
            bomb.Ignite(fuseTime);
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.G)) DebugIgnite();
        }
    }
}