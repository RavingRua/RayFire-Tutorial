using System.Collections;
using RayFire;
using UnityEngine;

namespace Finished.Scripts
{
    public class Bomb : MonoBehaviour
    {
        public GameObject bombBody; // 弹体对象
        public RayfireBomb rayfireBomb; // 需要引爆的 RayfireBomb
        public GameObject explosion; // 爆炸效果对象

        // 手榴弹点火
        public void Ignite(float fuseTime)
        {
            StartCoroutine(ExplodeCoroutine(fuseTime)); // 引信点火
        }

        private IEnumerator ExplodeCoroutine(float fuseTime)
        {
            yield return new WaitForSeconds(fuseTime); // 引信时间
            Explode(); // 爆炸
        }

        private void Explode()
        {
            bombBody.GetComponent<RayfireRigid>().Demolish(); // 弹体破碎
            rayfireBomb.Explode(0); // 产生冲击波

            var exp = Instantiate(explosion);
            exp.transform.position = transform.position;
        }
    }
}