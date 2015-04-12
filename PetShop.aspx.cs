using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PetShop : System.Web.UI.Page
{

    private void initPositionRol()
    {
        DropDownList1.Items.Clear();
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "Perros")
        {
            CheckBoxList1.Items.Clear();
            CheckBoxList1.Items.Add("Perro Siberiano");
            CheckBoxList1.Items.Add("Perro Baset Hound");
            CheckBoxList1.Items.Add("Perro Labrador");
            CheckBoxList1.Items.Add("Perro Boxer");
            CheckBoxList1.Items.Add("Perro Criollo");
            CheckBoxList1.Items.Add("Perro coker");
            CheckBoxList1.Items.Add("Perro Pitbull");
            CheckBoxList1.Items.Add("Perro Schnauzer");
            CheckBoxList1.Items.Add("Perro Schnauzer");
        }

        if (DropDownList1.SelectedValue == "Gatos")
        {
            CheckBoxList1.Items.Clear();
            CheckBoxList1.Items.Add("Gato SIames");
            CheckBoxList1.Items.Add("Gato Egipcio");
            CheckBoxList1.Items.Add("Gato persa");
            CheckBoxList1.Items.Add("Gato Exotico");
            CheckBoxList1.Items.Add("Gato Bengala");
            CheckBoxList1.Items.Add("Gato Bosuqe de Noruega");
            CheckBoxList1.Items.Add("Gato abisinio");
            CheckBoxList1.Items.Add("gato British SHothair");
            CheckBoxList1.Items.Add("Gato Ragdoll");
        }

        if (DropDownList1.SelectedValue == "Accesorios Gatos")
        {
            CheckBoxList1.Items.Clear();
            CheckBoxList1.Items.Add("Casa para gato pequeña");
            CheckBoxList1.Items.Add("Casa Para gato grande");
            CheckBoxList1.Items.Add("Rascador");
            CheckBoxList1.Items.Add("JUguete Pollo para gato");
            CheckBoxList1.Items.Add("Ropa arbrigadora para gato");
        }

        if (DropDownList1.SelectedValue == "Accesorios Perros")
        {
            CheckBoxList1.Items.Clear();
            CheckBoxList1.Items.Add("Casa para Perro Grande");
            CheckBoxList1.Items.Add("Casa Para perro Pequeña");
            CheckBoxList1.Items.Add("Juguete de goma pollo para perro");
            CheckBoxList1.Items.Add("Chompa para perro");
            CheckBoxList1.Items.Add("zapatos apra perro");
            CheckBoxList1.Items.Add("Corte de pelo");
            CheckBoxList1.Items.Add("Bañado completo");
          //  CheckBoxList1.Items.Add("gato British SHothair");
          //  CheckBoxList1.Items.Add("Gato Ragdoll");
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        if (RadioButtonList1.Items[0].Selected == true)
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Perros");
            DropDownList1.Items.Add("Gatos");
        }

        if (RadioButtonList1.Items[1].Selected == true)
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Accesorios Perros");
            DropDownList1.Items.Add("Accesorios Gatos");
        }
    }
}