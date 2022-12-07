using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Catalogos.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Prueba : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Prueba(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string test;
        CategoriaProducto categoriaProducto;
        CategoriaCliente cliente;

        public CategoriaCliente Cliente
        {
            get => cliente;
            set => SetPropertyValue(nameof(Cliente), ref cliente, value);
        }

        public CategoriaProducto CategoriaProducto
        {
            get => categoriaProducto;
            set => SetPropertyValue(nameof(CategoriaProducto), ref categoriaProducto, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Test
        {
            get => test;
            set => SetPropertyValue(nameof(Test), ref test, value);
        }

        [Delayed(), VisibleInListViewAttribute(true)]
        [RuleRequiredField]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PopupPictureEdit, DetailViewImageEditorMode = ImageEditorMode.DropDownPictureEdit, ListViewImageEditorCustomHeight = 40)]
        public byte[] Foto
        {
            get { return GetDelayedPropertyValue<byte[]>(nameof(Foto)); }
            set { SetDelayedPropertyValue<byte[]>(nameof(Foto), value); }
        }

    }
}