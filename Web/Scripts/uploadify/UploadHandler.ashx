<%@ WebHandler Language="C#" Class="UploadHandler" %>

using System;
using System.Web;
using System.IO;
using System.Linq;

public class UploadHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {

        context.Response.ContentType = "text/plain";
        context.Response.Charset = "utf-8";
        System.Collections.Generic.Dictionary<string, string> extTable = new System.Collections.Generic.Dictionary<string, string>();
        extTable.Add("image", "gif,jpg,jpeg,png,bmp");
        extTable.Add("flash", "swf,flv");
        extTable.Add("media", "swf,flv,mp3,wav,wma,wmv,mid,avi,mpg,asf,rm,rmvb");
        extTable.Add("file", "doc,docx,xls,xlsx,ppt,htm,html,txt,zip,rar,gz,bz2,apk,app");

        HttpPostedFile file = context.Request.Files["Filedata"];
        string path = @context.Request["folder"];
        string fileName = @context.Request["customname"];
        string Upload = @context.Request["Upload"];
        if (string.IsNullOrEmpty(fileName))
        {
            fileName = file.FileName;
        }
        else
        {
            if (fileName.IsOnlyNumber())
            {
                fileName = DateTime.Now.Ticks.ToString();
            }

            fileName += file.FileName.Substring(file.FileName.LastIndexOf("."));
        }


        string fileExtName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToLower();

        bool isAllow = false;
        foreach (var t in extTable)
        {
            if (t.Value.Split(',').Contains(fileExtName))
            {
                isAllow = true; ;
                break;
            }
        }
        if (!isAllow)
        {
            context.Response.Write("0,扩展名非法");
            return;
        }



        string uploadPath = HttpContext.Current.Server.MapPath(path) + "\\";

        if (file != null)
        {
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }
            file.SaveAs(uploadPath + fileName);
            //下面这句代码缺少的话，上传成功后上传队列的显示不会自动消失
            context.Response.Write("1," + fileName);
        }
        else
        {
            context.Response.Write("0,");
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }


}