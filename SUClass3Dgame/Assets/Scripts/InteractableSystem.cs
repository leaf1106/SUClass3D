using UnityEngine;
using UnityEngine.Events;

namespace Leaf
{
    /// <summary>
    /// ���ʨt�� : �������a�O�_�i�J�åB���椬��
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("��ܸ��")]
        private DialogueData dataDialogue;
        [SerializeField, Header("��ܵ�����ƥ�")]
        private UnityEvent onDialogueFinish;         //Unity�ƥ�

        private string nameTarget = "PlaterCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("�e����ܨt��").GetComponent < DialogueSystem > ();
        }

        // 3D ����A��
        // ��ӸI���ƥ󥲶��䤤�@�ӤĿ� Is Trigger
        // �I���}�l
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameTarget))
            {
                print(other.name);
                dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
            }
        }

        //�I������
        private void OnTriggerExit(Collider other)
        {
            
        }

        //�I������
        private void OnTriggerStay(Collider other)
        {
            
        }

        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }
    }
}

