using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;

    public void Magic(int point)
    {
        this.mp -= point;

        if (mp >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
// 以下Boss関数内のLESSONメモです。---------------------------------------

  //  private int hp = 100; // 体力
  //  private int power = 25; // 攻撃力

  //  public void Attack()
  //  {
        // 攻撃用の関数
  //      Debug.Log(this.power + "のダメージを与えた");

  //  }

  //  public void Defence(int damege)
  //  {
        // 防御用の関数
  //      Debug.Log(damege + "のダメージを受けた");
  //      this.hp -= damege;
  //  }

}


public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {

    //★課題★
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        //for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("順番に表示: " + array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("逆順に表示: " + array[4 - i]);
        }

        Boss lastboss = new Boss();

    //★発展課題★
        //Magic関数を10回より多く使うと、mpが足りないメッセージが出ることを確認
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }



 // 以下Start関数内のLESSONメモです。------------------------------------------

        //  Boss lastboss = new Boss();

        //  lastboss.Attack();
        //  lastboss.Defence(3);


        //要素数5の配列を初期化する
        //string[] points = new string[5];

        //配列の各要素に値を入力する
        //points[0] = "あ";
        //points[1] = "い";
        //points[2] = "う";
        //points[3] = "え";
        //points[4] = "お";

        //配列の要素をすべて表示する
        //for(int i = 0; i < 5; i++)
        //{
        //  Debug.Log(points[i]);
        //}

        //配列を初期化する
        // int[] points = { 10, 20, 30, 40, 50, 60, 70, 80 };

        // Debug.Log("配列の長さは" + points.Length);

        //配列の要素数の分だけ処理を繰り返す
        // for (int i = 0; i<points.Length; i++)
        // {
        //配列の要素が50以上の場合
        //    if (points[i] >= 20)
        //    {
        //配列の要素を表示する
        //        Debug.Log(points[i]);
        //    }
        // }

        //  HelloName(3);
        //  Goodbye("UnityChan");
        // int num = Add(3, 6, 1);
        // Debug.Log(num);
    }

    // Update is called once per frame
    void Update () {
		
	}

    //void HelloName(int name)
    //{
      //  Debug.Log("Hello," + name);
    //}

    //void Goodbye(string name)
    //{
      //  Debug.Log("Goodbye," + name);
    //}

    //int Add(int a, int b, int c)
    //{
      //  int d = a + b + c ;
      //  return d;
    //}


}
