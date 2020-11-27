using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroud : MonoBehaviour
{
    

    // public Text moneyForSecDisplayer; 
    [HideInInspector]
    public int moneyForSec;
    public int startMoneyForSec = 2;
    public int alba1 = 0;
    public int alba2 = 0;
    public int alba3 = 0;
    public int alba4 = 0;
    private int[] secMoneyArray = new int[5] { 0, 10, 20, 50, 100 };
    private int[] costArray = new int[5] { 0, 10000, 35000, 85000, 170000 };


    public Data dataController;

    void Start()
    {
        dataController.LoadAlba(this);
        StartCoroutine("AddMoneyLoop");
        updateUI();
    }

    void OnClickAlba1()
    {
        if (dataController.GetMoney() >= costArray[1])
        {
            dataController.SubMoney(costArray[1]);
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    void OnClickAlba2()
    {
        if (dataController.GetMoney() >= costArray[2])
        {
            dataController.SubMoney(costArray[2]);
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    void OnClickAlba3()
    {
        if (dataController.GetMoney() >= costArray[3])
        {
            dataController.SubMoney(costArray[3]);
            updateUI();
            dataController.SaveAlba(this);
        }
    }
    void OnClickAlba4()
    {
        if (dataController.GetMoney() >= costArray[4])
        {
            dataController.SubMoney(costArray[4]);
            updateUI();
            dataController.SaveAlba(this);
        }
    }

    IEnumerator AddMoneyLoop()
    {
        while (true)
        {
            if (alba1 == 1)
            {
                dataController.AddMoney(secMoneyArray[1]);
            } else if (alba2 == 1){
                dataController.AddMoney(secMoneyArray[2]);
            } else if (alba3 == 1){
                dataController.AddMoney(secMoneyArray[3]);
            } else if (alba4 == 1){
                dataController.AddMoney(secMoneyArray[4]);
            }

            yield return new WaitForSeconds(1.0f);
        }
    }

    public void updateUI()
    {

        //moneyForSecDisplayer.text = "초당 "+ secMoneyArray[Albalevel]+"코인";

    }
}
