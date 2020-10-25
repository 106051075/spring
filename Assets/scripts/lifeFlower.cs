using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeFlower : MonoBehaviour
{
    public Animator ani;
    //public static int hp = 1;
    public static int SET = 2;
    [SerializeField] private GameObject SunFlowerEnergyTank1;
    [SerializeField] private GameObject SunFlowerEnergyTank2;
    [SerializeField] private GameObject SunFlowerEnergyTank3;

    void Update()
    {
        if(CoreOfLife.aniOn == true)
        {
            ani.SetBool("click", true);
            CoreOfLife.aniOn = false;
        }
        if (CoreOfLife.aniOff == true)
        {
            ani.SetBool("click", false);
            CoreOfLife.aniOff = false;
        }
        if (SET == 1)
        {
            SunFlowerEnergyTank1.SetActive(true);
            SunFlowerEnergyTank2.SetActive(false);
            SunFlowerEnergyTank3.SetActive(false);
        }
        if (SET == 2)
        {
            SunFlowerEnergyTank1.SetActive(true);
            SunFlowerEnergyTank2.SetActive(true);
            SunFlowerEnergyTank3.SetActive(false);
        }
        if (SET == 3)
        {
            SunFlowerEnergyTank1.SetActive(true);
            SunFlowerEnergyTank2.SetActive(true);
            SunFlowerEnergyTank3.SetActive(true);
        }
    }

}
