using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        while (true)
        {


            if (this.mp >= 5)
            {
                this.mp -= 5;

                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + ".");

                continue;
            }

            else
            {
                Debug.Log("MPが足りないため魔法が使えない");

                break;
            }
        }


    }
}
public class Test : MonoBehaviour
{

    void Start()
    {


        Boss lastboss = new Boss();

        lastboss.Magic();




    }

    // Update is called once per frame
    void Update()
    {

    }
}