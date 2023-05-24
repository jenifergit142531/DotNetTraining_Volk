using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspclass3
{
    public partial class FileUploadForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((FileUpload1.PostedFile!=null)&&(FileUpload1.PostedFile.ContentLength>0))
            {
                var count = 0;
                foreach (HttpPostedFile uploadedfile in FileUpload1.PostedFiles)
                {
                    string fn = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                    string saveLocation = Server.MapPath("upload") + "\\" + fn;
                    try
                    {
                        // FileUpload1.PostedFile.SaveAs(saveLocation);
                        uploadedfile.SaveAs(saveLocation);
                        count++;

                    }
                    catch (Exception ex)
                    {
                        Label2.Text = "Error in uploading " + ex.Message;
                    }
                }
                   // Label2.Text = "The file is uploaded";
                   if(count > 0)
                {
                    Label2.Text = count + "files has been uploaded";
                }
                }
                

            

            else
            {
                Label2.Text = "Please select the file to upload";
            }
        }
    }
}