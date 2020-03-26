using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Labs
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Lab3AppForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem insertCircle;
		private System.Windows.Forms.MenuItem insertSquare;
		private System.Windows.Forms.MenuItem insertTriangle;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private IContainer components;

		public Lab3AppForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			DataModel dm = new DataModel();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Circle");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Square");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Triangle");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Shape", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.insertCircle = new System.Windows.Forms.MenuItem();
            this.insertSquare = new System.Windows.Forms.MenuItem();
            this.insertTriangle = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem1});
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6});
            this.menuItem5.Text = "File";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Exit";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.insertCircle,
            this.insertSquare,
            this.insertTriangle});
            this.menuItem1.Text = "Insert";
            // 
            // insertCircle
            // 
            this.insertCircle.Index = 0;
            this.insertCircle.Text = "Circle";
            this.insertCircle.Click += new System.EventHandler(this.insertCircle_Click);
            // 
            // insertSquare
            // 
            this.insertSquare.Index = 1;
            this.insertSquare.Text = "Square";
            this.insertSquare.Click += new System.EventHandler(this.insertSquare_Click);
            // 
            // insertTriangle
            // 
            this.insertTriangle.Index = 2;
            this.insertTriangle.Text = "Triangle";
            this.insertTriangle.Click += new System.EventHandler(this.insertTriangle_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total area=0, Total perimeter=0";
            // 
            // treeView1
            // 
            this.treeView1.ContextMenu = this.contextMenu1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "Circle";
            treeNode2.Name = "";
            treeNode2.Text = "Square";
            treeNode3.Name = "";
            treeNode3.Text = "Triangle";
            treeNode4.Name = "";
            treeNode4.Text = "Shape";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(480, 250);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // Lab3AppForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(480, 271);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Lab3AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab3";
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Lab3AppForm());
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			TreeNode selectedNode = treeView1.SelectedNode;
			string tagFullName="";
			if(selectedNode.Tag!=null)
			{
                tagFullName=selectedNode.Tag.GetType().FullName;
			}


			contextMenu1.MenuItems.Clear();
			
			if(selectedNode.Text=="Circle")
			{ 
				MenuItem menuItem1 = new MenuItem("Insert circle");
				menuItem1.Click += new System.EventHandler(this.insertCircle_Click);
				contextMenu1.MenuItems.Add(menuItem1);				
			}
			else if(selectedNode.Text=="Square")
			{ 
				MenuItem menuItem1 = new MenuItem("Insert square");
				menuItem1.Click += new System.EventHandler(this.insertSquare_Click);
				contextMenu1.MenuItems.Add(menuItem1);				
			}
			else if(selectedNode.Text=="Triangle")
			{ 
				MenuItem menuItem1 = new MenuItem("Insert triangle");
				menuItem1.Click += new System.EventHandler(this.insertTriangle_Click);
				contextMenu1.MenuItems.Add(menuItem1);				
			}
			else if(tagFullName=="Labs.Circle")
			{
				MenuItem menuItem1 = new MenuItem("Show circle properties");
				menuItem1.Click += new System.EventHandler(this.showCircleData_Click);
				contextMenu1.MenuItems.Add(menuItem1);
			}
			else if(tagFullName=="Labs.Square")
			{
				MenuItem menuItem1 = new MenuItem("Show square properties");
				menuItem1.Click += new System.EventHandler(this.showSquareData_Click);
				contextMenu1.MenuItems.Add(menuItem1);
			}
			else if(tagFullName=="Labs.Triangle")
			{
				MenuItem menuItem1 = new MenuItem("Show triangle properties");
				menuItem1.Click += new System.EventHandler(this.showTriangleData_Click);
				contextMenu1.MenuItems.Add(menuItem1);
			}
		
		}

		private void insertCircle_Click(object sender, System.EventArgs e)
		{
			AddShapeForm asf=new AddShapeForm(1);
			asf.ShowDialog(this);

			if (asf.DialogResult == DialogResult.OK)
			{
				if(asf.getSelectedType()==1)
				{
					var shape = new Circle(asf.getTextBoxInput());
					DataModel.getAllElementsList().Add(shape);	
					TreeNode tn = new TreeNode();
					tn.Text=shape.ToString();
					tn.Tag=shape;
					treeView1.Nodes[0].Nodes[0].Nodes.Add(tn);									

				}				

				label1.Text="Total area="+DataModel.getTotalArea()+", Total perimeter="+DataModel.getTotalPerimeter();
				asf.Dispose();
			}
		}

		private void insertSquare_Click(object sender, System.EventArgs e)
		{
			AddShapeForm asf = new AddShapeForm(2);
			asf.ShowDialog(this);

			if (asf.DialogResult == DialogResult.OK)
			{
				if (asf.getSelectedType() == 1)
				{
					var shape = new Square(asf.getTextBoxInput());
					DataModel.getAllElementsList().Add(shape);
					TreeNode tn = new TreeNode();
					tn.Text = shape.ToString();
					tn.Tag = shape;
					treeView1.Nodes[0].Nodes[0].Nodes.Add(tn);

				}

				label1.Text = "Total area=" + DataModel.getTotalArea() + ", Total perimeter=" + DataModel.getTotalPerimeter();
				asf.Dispose();
			}
		}

		private void insertTriangle_Click(object sender, System.EventArgs e)
		{
			AddShapeForm asf = new AddShapeForm(3);
			asf.ShowDialog(this);

			if (asf.DialogResult == DialogResult.OK)
			{
				if (asf.getSelectedType() == 1)
				{
					var shape = new Triangle(asf.getTextBoxInput());
					DataModel.getAllElementsList().Add(shape);
					TreeNode tn = new TreeNode();
					tn.Text = shape.ToString();
					tn.Tag = shape;
					treeView1.Nodes[0].Nodes[0].Nodes.Add(tn);

				}

				label1.Text = "Total area=" + DataModel.getTotalArea() + ", Total perimeter=" + DataModel.getTotalPerimeter();
				asf.Dispose();
			}
		}

		private void showCircleData_Click(object sender, System.EventArgs e)
		{			
			TreeNode tn= treeView1.SelectedNode;
			var shape =(Circle)tn.Tag;
			string message = "";
			message+="Radius="+shape.getRadius();
			message+="\nX pos="+shape.getXPos();
			message+="\nY pos="+shape.getYPos();
								
			string caption = "Circle properties";
			MessageBoxButtons buttons = MessageBoxButtons.OK;					
		
			MessageBox.Show(this, message, caption, buttons,
				MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);			

		}

		private void showSquareData_Click(object sender, System.EventArgs e)
		{
			TreeNode tn = treeView1.SelectedNode;
			var shape = (Square)tn.Tag;
			string message = "";
			message += "Side value=" + shape.getSide();
			message += "\nX pos=" + shape.getXPos();
			message += "\nY pos=" + shape.getYPos();

			string caption = "Square properties";
			MessageBoxButtons buttons = MessageBoxButtons.OK;

			MessageBox.Show(this, message, caption, buttons,
				MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

		}

		private void showTriangleData_Click(object sender, System.EventArgs e)
		{
			TreeNode tn = treeView1.SelectedNode;
			var shape = (Triangle)tn.Tag;
			string message = "";
			message += "Side value=" + shape.getSide();
			message += "\nX pos=" + shape.getXPos();
			message += "\nY pos=" + shape.getYPos();

			string caption = "Triangle properties";
			MessageBoxButtons buttons = MessageBoxButtons.OK;

			MessageBox.Show(this, message, caption, buttons,
				MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (treeView1.SelectedNode.Name == "Shape")
				return;
			else if (treeView1.SelectedNode.Name == "Circle")
				showCircleData_Click();
			else if (treeView1.SelectedNode.Name == "Square")
				showSquareData_Click();
			else if (treeView1.SelectedNode.Name == "Triangle")
				showTriangleData_Click();
		}
	}
}
