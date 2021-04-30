using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 공격 발사 스크립트
/// </summary>

public class Attack : MonoBehaviour
{
    public GameObject AttackGo;

    public Transform attackspawnposition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            //공격
            Instantiate(AttackGo, transform.position, transform.rotation);
        }

    }
}
