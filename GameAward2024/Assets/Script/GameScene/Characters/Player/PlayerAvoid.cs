using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAvoid : MonoBehaviour
{
    //Ïé¾
    private float rotXZ = 3.0f;  //vC[ñ]pxXZ
    private float rotY = 0.0f;   //vC[ñ]pxY
    private float lateRotXZ;
    private float lateRotY;
    private float radius = -5.0f;

    private Vector3 playerPos;  //vC[ÀW
    private Vector3 bossPos;    //{XÀW
    private Vector3 distance;   //vC[Æ{XÌ£
    private Vector3 dodgeDistance;  //vC[Ìñð£vZp

    private bool AvoidFlag;
    private Vector2 Period;

    // Start is called before the first frame update
    void Start()
    {
        AvoidFlag = false;
        Period = new Vector2();
    }

    private void Update()
    {
        Vector2 dir = PlayerActionControler.PParam.m_moveDirect;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!AvoidFlag)
            {
                AvoidFlag = true;
                if(dir.x < 0.0f)
                {
                    Period.x = -0.3f;
                }
                else if(dir.x > 0.0f)
                {
                    Period.x = 0.3f;
                }
                if (dir.y < 0.0f)
                {
                    Period.y = -0.3f;
                }
                else if (dir.y > 0.0f)
                {
                    Period.y = 0.3f;
                }

            }

            Debug.Log(dir);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!AvoidFlag) return;

        GameScene.ManagerContainer.GetManagerContainer().m_characterManager.m_player.GetComponent<PlayerMove>().PlayerCircularRotation(Period.x, Vector3.up);

        Period *= 1.3f;

        if(Period.x >= 8.0f)
        {
            Period.x = 0.0f;
            AvoidFlag = false;
        }

    }

    public void OnAvoid()
    {

    }
}
