using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] points = new int[5];
        points[0]= 0;
        points[1]= 1;
        points[2]= 2;
        points[3]= 3;
        points[4]= 4;
        for (int i = 4; i >= 0; i--) {
            Debug.Log(points[i]);
        }

        Boss boss = new Boss();
        for (int i = 0; i < 10; i++){
            boss.Magic();
        }
        boss.Magic();
    }

    public class Boss {
        private int mp = 53;
        public void Magic(){
            mp -= 5;
            if (mp <= 0){
                Debug.Log("MPが足りない！");
            }
            else{
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}


