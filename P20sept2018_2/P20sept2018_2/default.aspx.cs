using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P20sept2018_2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "PreInit";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "Init";
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "InitComplete";
        }
        protected override void OnPreLoad(EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "PreLoad";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = Label1.Text + "<br/>" + "Load";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            Label1.Text = Label1.Text + "<br/>" + "btnSubmit_Click";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "LoadComplete";
        }
        protected override void OnPreRender(EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "PreRender";
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "SaveStateComplete";
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            Label1.Text = Label1.Text + "<br/>" + "UnLoad";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}