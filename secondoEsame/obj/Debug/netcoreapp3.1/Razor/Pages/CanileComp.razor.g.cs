#pragma checksum "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcbeaec5e7eca9a49d984c8e9207769d47402a35"
// <auto-generated/>
#pragma warning disable 1591
namespace secondoEsame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using secondoEsame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using secondoEsame.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\_Imports.razor"
using secondoEsame.CanileFolder;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/canilecomp")]
    public partial class CanileComp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Canile di San Giovanni Valdarno</h3>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
 if (nuovoCane == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                                              (e => Aggiungi())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Aggiungi cane");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-hover");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, @"<tr>
            <td>ID</td>
            <td>Nome</td>
            <td>Anno di nascita</td>
            <td>Razza</td>
            <td>Genere</td>
            <td>Data addozione</td>
            <td>Data acquisizione</td>
            <td>Sterilizzato</td>
            <td>Data Sterilizz</td>
            <td>Modifica</td>
            <td>Cancella</td>
        </tr>
");
#nullable restore
#line 22 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
         foreach (Canile singolo in db.canili)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 25 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Id_cane

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 26 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Nome_cane

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 27 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Anno_nascita

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 28 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Razza

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 29 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Genere

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 30 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Data_addozione

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 31 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Data_acquisizione

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 32 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Sterilizzato

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 33 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                     singolo.Data_steril

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "oi oi-pencil");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                                                           (e => Modifica(singolo))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Modifica");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "oi oi-trash");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                                                          (e => Cancella(singolo))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Cancella");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 39 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 41 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "label");
            __builder.AddMarkupContent(57, "\r\n    Nome del cane\r\n    ");
            __builder.OpenElement(58, "input");
            __builder.AddAttribute(59, "placeholder", "Nome del cane");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                        nuovoCane.Nome_cane

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoCane.Nome_cane = __value, nuovoCane.Nome_cane));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    <br>\r\n    ");
            __builder.OpenElement(64, "label");
            __builder.AddMarkupContent(65, "Anno di nascita\r\n        ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "date");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                            nuovoCane.Anno_nascita

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoCane.Anno_nascita = __value, nuovoCane.Anno_nascita, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    <br>\r\n    ");
            __builder.OpenElement(72, "label");
            __builder.AddMarkupContent(73, "Razza del cane\r\n        ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "placeholder", "Razza del cane");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                            nuovoCane.Razza

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoCane.Razza = __value, nuovoCane.Razza));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    <br>\r\n    ");
            __builder.OpenElement(80, "label");
            __builder.AddMarkupContent(81, "Genere del cane\r\n        ");
            __builder.OpenElement(82, "input");
            __builder.AddAttribute(83, "placeholder", "Genere del cane");
            __builder.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                            nuovoCane.Genere

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoCane.Genere = __value, nuovoCane.Genere));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n    <br>\r\n    ");
            __builder.OpenElement(88, "label");
            __builder.AddMarkupContent(89, "Data di addozione\r\n        ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "date");
            __builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                            nuovoCane.Data_addozione

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoCane.Data_addozione = __value, nuovoCane.Data_addozione, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n    <br>\r\n    ");
            __builder.OpenElement(96, "label");
            __builder.AddMarkupContent(97, "Data di acquisizione\r\n        ");
            __builder.OpenElement(98, "input");
            __builder.AddAttribute(99, "type", "date");
            __builder.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                            nuovoCane.Data_acquisizione

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoCane.Data_acquisizione = __value, nuovoCane.Data_acquisizione, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    <br>\r\n    ");
            __builder.OpenElement(104, "label");
            __builder.AddMarkupContent(105, "Sterilizzato\r\n        ");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "placeholder", "Sterilizzato");
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                            nuovoCane.Sterilizzato

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoCane.Sterilizzato = __value, nuovoCane.Sterilizzato));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n    <br>\r\n    ");
            __builder.OpenElement(112, "label");
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "date");
            __builder.AddAttribute(116, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                            nuovoCane.Data_steril

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(117, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovoCane.Data_steril = __value, nuovoCane.Data_steril, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    <br>\r\n    ");
            __builder.OpenElement(120, "button");
            __builder.AddAttribute(121, "class", "btn btn-success");
            __builder.AddAttribute(122, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                                              (e => Salva())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(123, "Salva");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.OpenElement(125, "button");
            __builder.AddAttribute(126, "class", "btn btn-danger");
            __builder.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
                                             (e => Annulla())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(128, "Annulla");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
#nullable restore
#line 79 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\ardit\source\repos\secondoEsame\secondoEsame\Pages\CanileComp.razor"
       
    private Canile nuovoCane;

    private void Aggiungi()
    {
        nuovoCane = new Canile();
    }
    private void Modifica(Canile modCane)
    {
        nuovoCane = modCane;
    }
    private void Cancella(Canile daCancellare)
    {
        db.canili.Remove(daCancellare);
        db.SaveChanges();
    }
    public void Annulla()
    {
        nuovoCane = null;
    }
    private void Salva()
    {
        if (nuovoCane.Id_cane == 0)
        {
            db.canili.Add(nuovoCane);
        }
        else
        {
            db.canili.Update(nuovoCane);
        }
        db.SaveChanges();
        nuovoCane = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BaseDati db { get; set; }
    }
}
#pragma warning restore 1591
