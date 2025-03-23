
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    GameObject rightController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            //���𐶐��i�u�q�G�����L�[�ŉE�N���b�N��Create��3D Object��Sphere�v�Ɠ�����Ƃł��j
            GameObject go = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere));
            //�����������̈ʒu���E��R���g���[���̈ʒu�ɕύX
            go.transform.position = rightController.transform.position;
            //�����������̃T�C�Y�𔼌a0.1m�ɕύX
            go.transform.localScale *= 0.1f;
        }
    }
}