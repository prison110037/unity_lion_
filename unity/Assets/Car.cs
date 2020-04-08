using UnityEngine;

// 註解 : 用來說明紀錄等等.. 只會在此腳本內看到
// 摘要 summary : 敘述此內容，會在其他腳本內看到 - 提高維護性與擴充性
/// <summary>
/// 定義汽車物件
/// </summary>
public class Car : MonoBehaviour
{
    // 認識第一個成員:欄位 field - 儲存物件資料

    // 資料類型
    // cc數     - 2000     - 整數 int
    // 重量     - 100.9    - 浮數點 float
    // 品牌     - BMW      - 字串string
    // 煞車     - 是否開啟 -  布林值 bool

    // 定義欄位語法:
    // 資料類型 欄位名稱;
    // 預設值
    // int float 為0
    // string 為""
    // bool 為 false 
    int cc = 2000;
    float weight = 100.9f;
    string brand = "BMW";
    bool brake = false;
 }
