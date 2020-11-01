using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skill : MonoBehaviour
{
    // Start is called before the first frame update
    int lifeFlower1;
    public float speed = 0.1f;
    public Camera Camera_ForGetMouse;
    public Transform skill1;
    public Transform skill2;
    public float cooltime = 1;
    private Image FilledImage;
    private float timer = 0;
    private bool isStartTimer = false;


    void Start()
    {
      FilledImage = transform.Find("技能讀條_底").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = Input.mousePosition;
        skill1.transform.localPosition = new Vector3(MousePos.x - 385, MousePos.y - 210, 0);
        skill2.transform.localPosition = new Vector3(MousePos.x - 385, MousePos.y - 210, 0);
        //print(isStartTimer);
     
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
            {
                //GetComponent<CanvasGroup>().alpha = 1;
                isStartTimer = true;
            }  
        if (isStartTimer)
        {        
            timer += Time.deltaTime;
            FilledImage.fillAmount = (cooltime - timer) / cooltime;
        }
        if (timer > cooltime || Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
           {
             FilledImage.fillAmount = 0;
             timer = 0;
             isStartTimer = false;
            //GetComponent<CanvasGroup>().alpha = 0;
        }

    }
}
