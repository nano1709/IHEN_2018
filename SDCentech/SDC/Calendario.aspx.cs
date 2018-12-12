using SDC.BLL.Interfaces;
using SDC.BLL.Metotdos;
using System;
using System.Linq;
using System.Text;

namespace SDC
{
    public partial class Calendario : System.Web.UI.Page
    {
        public IEventosCale eveCale;
        public String Eventos;

        public Calendario()
        {
            eveCale = new MEventosCale();
        }

        protected void Page_Load(object sender, EventArgs e)
        {


            var listaEvento = eveCale.ListaEvento();
            var lista = listaEvento.Select(x =>
            new
            {
                x.id,
                x.title,
                x.start,
                x.end,
                x.url,
                x.className,
                x.editable
            }).ToList();

            //foreach (var item in lista)
            //{
            //    string script = string.Format("var myName = '{0} {1}';", item.id, item.title);

            //    if (!ClientScript.IsClientScriptBlockRegistered("myScript"))
            //    {
            //        ClientScript.RegisterClientScriptBlock(typeof(_Default), "myScript", script, true);
            //    }
            //}
            StringBuilder sb = new StringBuilder();

            foreach (var item in lista)
            {
                sb.Append("{title: '" + item.title + "', start: '" + item.start + "', end: '" + item.end + "', url: '" + item.url + "', className: '" + item.className + "'},");
                Eventos = sb.ToString();
            }



        }

        protected void eventosCale_Click(object sender, EventArgs e)
        {
            Response.Redirect("EventosCalendario.aspx");
        }

        protected void agregarEvento_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroEventosCale.aspx");
        }
    }
}