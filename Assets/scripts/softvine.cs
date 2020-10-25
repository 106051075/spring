using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class softvine : MonoBehaviour
{
    public bool aniOn = false;
    public bool aniOff = false;
    public Animator ani;
    public static int hp1 = 1;
    private int SET = 2;
    [SerializeField] private GameObject SunFlowerEnergyTank1;
    [SerializeField] private GameObject SunFlowerEnergyTank2;
    [SerializeField] private GameObject SunFlowerEnergyTank3;

    void Update()
    {
        if (aniOn == true)
        {
            ani.SetBool("click", true);
            aniOn = false;
        }
        if (aniOff == true)
        {
            ani.SetBool("click", false);
            aniOff = false;
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
        touch();
    }
    private void touch()
    {
        if (CoreOfLife.isOver == true)
        {
            if (CoreOfLife.Contact == true)
            {
                if (Input.GetMouseButtonDown(0) && EnergyNumber.a <= 2 && EnergyNumber.a >= 0 && hp1 == 1)
                {
                    CoreOfLife.Click1 = true;
                    aniOn = true;
                    hp1 -= 1;
                    SET -= 1;
                }
                if (Input.GetMouseButtonDown(1) && EnergyNumber.a >= 1 && EnergyNumber.a <= 4 && hp1 == 0)
                {
                    CoreOfLife.Click2 = true;
                    aniOff = true;
                    hp1 += 1;
                    SET += 1;
                }
            }
        }
    }

}
