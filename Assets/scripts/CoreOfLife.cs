﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UI;

public class CoreOfLife : MonoBehaviour
{
    int lifeFlower1;
    public bool SkillaniOn = false;
    public static bool aniOn = false;
    public static bool aniOff = false;
    public static bool Click1 = false;
    public static bool Click2 = false; 
    public static bool Contact = false;
    public static bool isOver = false;
    public Animator ani;
    public static int hp = 1;
    private float timer_f = 0f;
    private int timer_i = 0;

    public int remind_i = 0;
    public bool remind_b = false;

    [SerializeField] private string selectableTag = "生命小花";
    [SerializeField] private GameObject RemindToRead;

    private void Start()
    {
        lifeFlower1 = LayerMask.NameToLayer("生命小花");
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            timer_f += Time.fixedDeltaTime;
            timer_i = (int)timer_f;
            Debug.Log(timer_i);
        }
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            timer_f = 0;
        }


        if(remind_b && GameManager.clickTheButton == 0)
        {
            RemindToRead.SetActive(true);
        }        
        else
        {
            RemindToRead.SetActive(false);
        }

        //print(isOver);
        //print(timer_f);
        ClickSelect();
        touch();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(selectableTag))
        {
            Contact = true;
            remind_b = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(selectableTag))
        {
            Contact = false;
            if (hp == 1 && Input.GetMouseButtonUp(1))
            {
                Click2 = false;
            }
        }
        if (other.gameObject.CompareTag(selectableTag))
        {
            Contact = false;
            if (hp == 0 && Input.GetMouseButtonUp(0))
            {
                Click1 = false;
            }
        }
    }

private void touch()
{
  if (isOver == true)
     {
        if (Contact == true)
            {
                if (timer_f >= 1.75)
                {
                    if (Input.GetMouseButton(0) && EnergyNumber.a <= 2 && EnergyNumber.a >= 0 && hp == 1)
                    {
                        Click1 = true;
                        aniOn = true;
                        hp -= 1;
                        lifeFlower.SET -= 1;
                    }

                    if (Input.GetMouseButton(1) && EnergyNumber.a >= 1 && EnergyNumber.a <= 4 && hp == 0)
                    {
                        Click2 = true;
                        aniOff = true;
                        hp += 1;
                        lifeFlower.SET += 1;
                    }
                }
            }
     }
        if (isOver == true)
        {
            if (Contact == true)
            {
                if (timer_f <= 2)
                   {
                    if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
                        {
                                GetComponent<CanvasGroup>().alpha = 1;
                        }
                   }
                if(timer_f >= 2 || Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
                   {
                      GetComponent<CanvasGroup>().alpha = 0;
                   }

            }
        }
        if (isOver == true)
        {
            if (Contact == false)
            {
                if (Input.GetMouseButtonDown(0)|| Input.GetMouseButtonDown(1))
                {   
                    ani.SetBool("click1", true);
                }
                else
                {
                    ani.SetBool("click1", false);
                }
            }
        }

    }

GameObject ClickSelect()
    {
        Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f,LayerMask.GetMask("生命小花"));
        var selection = hit.transform;
        if (selection.CompareTag(selectableTag))
        {
            isOver = true;
            return hit.transform.gameObject;
        }
        else
        {
            isOver = false;
            return null;
        }
    }
}
