using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using LitJson;
using UnityEngine.UI;

<<<<<<< HEAD
//这是dev修改
=======
//这是bob修改
>>>>>>> Bob
public class SelectionJSON : Editor {

	//添加菜单
     [MenuItem(@"SelectionJSON/CreateUI")]
     public static void CreateUI()
    {
        Object obj = Selection.activeObject;
        JsonData data = JsonMapper.ToObject(obj.ToString());
        JsonData temp = null;
        int result = -1;
        //TODO
        temp = TTFindJson(data, "ObjectData", "GameFileData", ref result);
        if (temp==null)
        {
            Debug.Log("没找到");
        }
        else
        {
            Debug.Log(temp["Tag"]);
        }             

    }
    public static JsonData TTFindJson(JsonData data,string key,string ctype,ref int result)
    {
        if (data==null)return null;
        if (result.Equals(1)) return data;
        result = -1;
        JsonData _data = null;
        
        try
        {            
            _data = data["Content"];
        }
        catch (System.Exception e)
        { 
            return null;
        }
        JsonData temp = null;
        temp = TTJudge(_data, "ctype", ctype, ref result);
        switch (result) 
        {
            case 1:
                return temp[key];
                break;
            case 0:
                temp = TTFindJson(_data, key, ctype, ref result);
                break;
            default:
                temp = TTFindJson(_data, key, ctype, ref result);
                break;
        }
        return temp;        
    }
    public static JsonData TTJudge(JsonData data,string key,string value,ref int result)
    {
        try
        {
            if (data[key].Equals(value))
            {
                result = 1;
                return data;            
            }
            else
            {
                result = 0;                
            }
        }
        catch (System.Exception)
        {
            result = -1;                       
        }
        return default(JsonData);
    }
    public static void AnalyzeLayer(JsonData obj)
    {
        
    }
    public static void AnalyzeImage()
    {

    }
    public static void AnalzeText()
    {

    }
    public static void AnalyzeButton()
    {

    }

}

public class TTUIConfiLayer
{
    public string ID;
    public string Version;
    public string Name;
    public string Content;
    public string Type;
}
