using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� �߻� ��ũ��Ʈ
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
            //����
            Instantiate(AttackGo, transform.position, transform.rotation);
        }

    }
}
