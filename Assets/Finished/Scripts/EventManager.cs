using UnityEngine;
using RayFire;

namespace Finished.Scripts
{
    public class EventManager : MonoBehaviour
    {
        // 注册事件
        private void Awake()
        {
            // Debug：当对象别破坏时通知
            RFDemolitionEvent.GlobalEvent += (RayfireRigid rigid) =>
                print("[Debug] " + rigid.gameObject.name + " is destroyed!");
            // Debug：当炸弹爆炸时通知
            RFExplosionEvent.GlobalEvent += (RayfireBomb bomb) =>
                print("[Debug] " + bomb.gameObject.name + " is exploded!");
        }
    }
}