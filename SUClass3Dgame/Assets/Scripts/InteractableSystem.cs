using UnityEngine;

namespace Leaf
{
    /// <summary>
    /// ���ʨt�� : �������a�O�_�i�J�åB���椬��
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("��ܸ��")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlaterCapsule";

        // 3D ����A��
        // ��ӸI���ƥ󥲶��䤤�@�ӤĿ� Is Trigger
        // �I���}�l
        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
        }

        //�I������
        private void OnTriggerExit(Collider other)
        {
            
        }

        //�I������
        private void OnTriggerStay(Collider other)
        {
            
        }
    }
}

