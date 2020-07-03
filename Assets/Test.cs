using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public class Boss
	{
		private int hp = 100;          // 体力
		private int power = 25; // 攻撃力
		private int mp = 53; //魔法体力

		// 攻撃用の関数
		public void Attack()
		{
			Debug.Log(this.power + "のダメージを与えた");
		}

		// 防御用の関数
		public void Defence(int damage)
		{
			Debug.Log(damage + "のダメージを受けた");
			// 残りhpを減らす
			this.hp -= damage;
		}

		//魔法攻撃用の
		public void Magic()
        {
            if (mp <5)
            {
				Debug.Log("MPが足りないため魔法が使えない");
				return;
            }
			//残りmpを減らす
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" +　mp);
		}
	}

	//配列テスト
	public class ArrayTest
    {
		//要素数5のint型の配列
		private int[] random = { 12, 345, 33, 42, 88 };

		public void OutputArrayAsc()
        {
			for (int i = 0; i<random.Length; i++)
			{
				Debug.Log(random[i]);
			}
        }

		public void OutputArrayDesc()
		{
			for (int i = random.Length - 1; i >= 0; i--)
			{
				Debug.Log(random[i]);
			}
		}
	}

	// Use this for initialization
	void Start () {
		ArrayTest arraytest = new ArrayTest();
		arraytest.OutputArrayAsc();
		arraytest.OutputArrayDesc();

		Boss firstboss = new Boss();
		for (int i =1; i <= 11 ; i++)
        {
			firstboss.Magic();
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
