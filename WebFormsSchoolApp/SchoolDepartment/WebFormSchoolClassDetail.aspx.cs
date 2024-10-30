using SchoolappBackend.BLL.BLLClasses;
using System;
using System.Web.UI;



namespace WebFormsSchoolApp.SchoolDepartment
{
    public partial class WebFormSchoolClassDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int schoolClassId = 0;
            string action = string.Empty;
            const string subject = "SchoolClass";


            if (Session["user"] == null)
            {
                Response.Redirect("../StartPage.aspx");
            }

            try
            {
                if (!IsPostBack)
                {
                    LabelMessage.Visible = false;
                    schoolClassId = Convert.ToInt32(Request.QueryString["schoolClassId"]);
                    action = Request.QueryString["action"];
                    HiddenFieldAction.Value = action;

                    if (action == "detail" || action == "update")
                    {
                        FillInControls(schoolClassId);  
                    }

                    switch (action)
                    {
                        case "detail":
                            LabelTitle.Text = subject + " Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                        case "insert":
                            LabelTitle.Text = "Insert new " + subject;
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        case "update":
                            LabelTitle.Text = "Update " + subject;
                            DisableAllControls(false);
                            ButtonSaveAndCancelVisible(true);
                            break;
                        default:
                            LabelTitle.Text = subject + " Detail";
                            DisableAllControls(true);
                            ButtonSaveAndCancelVisible(false);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                LabelMessage.Visible = true;
                LabelMessage.Text = "An error occured.Try later again.";
            }
        }

        private void FillInControls(int schoolClassId)
        {
            var schoolDepartmentBLL = new SchoolDepartmentBLL();
            var schoolClassSelected = schoolDepartmentBLL.GetSchoolClassById(schoolClassId);
           

            LabelSchoolClassIdValue.Text = Convert.ToString(schoolClassSelected.ClassId);
            TextBoxClassCode.Text = schoolClassSelected.ClassCode;
            TextBoxDescription.Text = schoolClassSelected.Description;
            TextBoxDegree.Text =  Convert.ToString(schoolClassSelected.Degree);
            TextBoxGrade.Text = Convert.ToString(schoolClassSelected.Grade);
        }



        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (SaveData())
                {
                    Response.Redirect("WebFormSearchCourse.aspx");
                }
            }
        }

        private void ButtonSaveAndCancelVisible(bool visible)
        {
            ButtonSave.Visible = visible;
            ButtonCancel.Visible = visible;
        }


        private void DisableAllControls(bool disable)
        {
            var enableControl = !disable;
            TextBoxClassCode.Enabled = enableControl;
            TextBoxDescription.Enabled = enableControl;
            TextBoxDegree.Enabled = enableControl;
            TextBoxGrade.Enabled = enableControl;
        }




        private bool SaveData()
        {
            bool succes = true;//todo aanpassen naar false

            var schoolDepartmentBLL = new SchoolDepartmentBLL();

            var SchoolClassId = 0;
            if (HiddenFieldAction.Value == "update")
            {
                SchoolClassId = Convert.ToInt32(LabelSchoolClassIdValue.Text.Trim());
            }

            var schoolClass = new SchoolappBackend.BLL.models.SchoolClass()
            {
                ClassId = SchoolClassId,
                ClassCode = TextBoxClassCode.Text.Trim(),
                Description = TextBoxDescription.Text.Trim(),
                Degree = Convert.ToInt32(TextBoxDegree.Text.Trim()),
                Grade = Convert.ToInt32(TextBoxGrade.Text.Trim()),
            };


            if (HiddenFieldAction.Value == "update") 
            {
                //succes = schoolDepartmentBLL.Update(schoolClass);
            }

            if (HiddenFieldAction.Value == "insert") 
            {
                //succes = schoolDepartmentBLL.Add(schoolClass);
            }
            return succes;
        }



        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebFormSchoolClass.aspx");
        }
    }
}