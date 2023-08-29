using DevExpress.Blazor;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Blazor.Editors.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestModal.Blazor.Server.Controllers
{

    public class AppearanceListViewController : ViewController<ListView>
    {
        DxGridListEditor editor;
        public AppearanceListViewController()
        {

        }
        protected override void OnActivated()
        {
            base.OnActivated();


        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            if (View.Editor is DxGridListEditor gridListEditor)
            {
                // Obtain the Component Adapter.
                editor = gridListEditor;
                IDxGridAdapter dataGridAdapter = editor.GetGridAdapter();
                dataGridAdapter.GridModel.CustomizeElement = Grid_CustomizeElement;
                dataGridAdapter.GridModel.ShowSearchBox = false;
                dataGridAdapter.GridModel.ColumnResizeMode = GridColumnResizeMode.NextColumn;
                dataGridAdapter.GridModel.SearchTextParseMode = GridSearchTextParseMode.GroupWordsByOr;
                dataGridAdapter.GridModel.PagerVisible = true;
                // dataGridAdapter.GridModel.FilterMenuButtonDisplayMode = GridFilterMenuButtonDisplayMode.Never;
                dataGridAdapter.GridModel.CssClass = "table table-striped table-pagination table-hover bg-white border table-responsive";
                dataGridAdapter.GridModel.AllowSort = true;
                //dataGridAdapter.GridModel.DetailRowTemplate = CustomDateRenderer.Create(new CustomDateModel() { Value=DateTime.Now});
                foreach (DxGridDataColumnModel column in dataGridAdapter.GridDataColumnModels)
                {
                    column.FilterMenuButtonDisplayMode = GridFilterMenuButtonDisplayMode.Never;
                }


            }

        }
        void Grid_CustomizeElement(GridCustomizeElementEventArgs e)
        {
            //if (e.ElementType == GridElementType.HeaderRow || e.ElementType == GridElementType.FooterRow || e.ElementType == GridElementType.PagerContainer)
            //{
            //    e.CssClass = "text-uppercase thead-light font-monospace";
            //}

            //// specific styles just for the header row. style the header cell individually using the cell classes below
            //if (e.ElementType == GridElementType.HeaderRow)
            //{
            //    e.CssClass = "text-uppercase thead-light";
            //}

            //if (e.ElementType == GridElementType.HeaderCell || e.ElementType == GridElementType.HeaderSelectionCell)
            //{
            //    e.CssClass = "p-1";
            //}

            //if (e.ElementType == GridElementType.DataCell)
            //{
            //    e.CssClass = " px-2 py-3 font-primary fs-7 text-start";

            //}

            //if (e.ElementType == GridElementType.DataRow)
            //{
            //    e.CssClass = "";
            //    e.Style = "cursor:pointer !important";
            //}
            //if (e.ElementType == GridElementType.DataRow && e.VisibleIndex % 2 == 1)
            //{
            //    e.CssClass = "";
            //    e.Style = "cursor:pointer !important;";
            //}

            //if (e.ElementType == GridElementType.SelectionCell)
            //{
            //    e.CssClass = "";
            //}

        }
    }


    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    //public partial class ViewController1 : ViewController
    //{
    //    // Use CodeRush to create Controllers and Actions with a few keystrokes.
    //    // https://docs.devexpress.com/CodeRushForRoslyn/403133/
    //    public ViewController1()
    //    {
    //        InitializeComponent();
    //        // Target required Views (via the TargetXXX properties) and create their Actions.
    //    }
    //    NewObjectViewController newObjectController;
    //    protected override void OnActivated()
    //    {
    //        base.OnActivated();
    //        newObjectController = Frame.GetController<NewObjectViewController>();
    //        if (newObjectController != null)
    //        {
    //            newObjectController.NewObjectAction.Execute += NewObjectAction_Execute;
    //            // Perform various tasks depending on the target View.
    //        }
    //    }

    //    private void NewObjectAction_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
    //    {
    //        IObjectSpace objectSpace = Application.CreateObjectSpace();


    //        if (e.SelectedChoiceActionItem.Caption == "Role")//if (View.ObjectTypeInfo.Type == typeof(Client) || View.Id == "Client_LookupListView")
    //        {
    //            PermissionPolicyRole test = objectSpace.CreateObject<PermissionPolicyRole>();
    //            DetailView detailView = Application.CreateDetailView(objectSpace, test);
    //            e.ShowViewParameters.TargetWindow = TargetWindow.NewModalWindow;
    //            e.ShowViewParameters.CreatedView = detailView;

    //        }
    //    }
    //    protected override void OnViewControlsCreated()
    //    {
    //        base.OnViewControlsCreated();
    //        // Access and customize the target View control.
    //    }
    //    protected override void OnDeactivated()
    //    {
    //        // Unsubscribe from previously subscribed events and release other references and resources.
    //        base.OnDeactivated();
    //    }
    //}

   
}
