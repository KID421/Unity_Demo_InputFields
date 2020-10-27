using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    // 輸入欄位陣列
    public InputField[] inputs;
    // 編號
    public int index;

    private void Start()
    {
        // 指定第一個被選取
        inputs[index].Select();
    }

    private void Update()
    {
        Change();
    }

    private void Change()
    {
        // 按 TAB
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // 編號遞增
            index++;
            // 避免跑出陣列外
            if (index == inputs.Length) index = 0;
            // 選取
            inputs[index].Select();
        }
    }

    public void ChangeByUI()
    {
        // 編號遞增
        index++;
        // 避免跑出陣列外
        if (index == inputs.Length) index = 0;
        // 選取
        inputs[index].Select();
    }
}
