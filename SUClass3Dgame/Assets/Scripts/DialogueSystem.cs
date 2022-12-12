using UnityEngine;
using TMPro;
using System.Collections;

namespace Leaf
{
    #region ��ưϰ�
    /// <summary>
    /// ��ܨt��
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        [SerializeField, Header("��ܶ���"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;
        [SerializeField, Header("�}�Y���")]
        private DialogueData dialogueOpening;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);
        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContents;
        private GameObject goTriangle;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            groupDialogue = GameObject.Find("�e����ܨt��").GetComponent<CanvasGroup>();
            textName = GameObject.Find("��ܪ̦W��").GetComponent<TextMeshProUGUI>();
            textContents = GameObject.Find("��ܤ��e").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("��ܧ����ϥ�");
            goTriangle.SetActive(false);

            StartCoroutine(FadeGroup());
            StartCoroutine(TypeEffect());
        }
        #endregion

        /// <summary>
        /// �H�J�H�X�s�ժ���
        /// </summary>
        private IEnumerator FadeGroup()
        {
            for (int i = 0; i < 10; i++)
            {
                groupDialogue.alpha += 0.1f;
                yield return new WaitForSeconds(0.04f);
            }
        }

        private IEnumerator TypeEffect()
        {
            textName.text = dialogueOpening.dialogueName;
            textContents.text = "";

            string dialogue = dialogueOpening.dialogueContents[0];

            for (int i = 0; i < dialogue.Length; i++)
            {
                textContents.text += dialogue[i];
                yield return dialogueInterval;

                
            }

            goTriangle.SetActive(true);

        }

    }

}