using System.Collections;
using UnityEngine;

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //要素数5の配列を初期化する
        int[] points = new int[5];

        //配列の各要素に値を代入する
        points[0] = 2;
        points[1] = 20;
        points[2] = 50;
        points[3] = 99;
        points[4] = 80;


        //配列全ての要素を表示する(正) 
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);

        }



        //配列全ての要素を表示する(負)
        for (int i = 4; i >=0; i--) {
           　　　　 Debug.Log(points[i]);

        }

    }
	// Update is called once per frame
	void Update () {
		
	}
}
