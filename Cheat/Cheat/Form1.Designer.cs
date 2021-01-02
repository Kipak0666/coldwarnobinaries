namespace Cheat
{
    // Token: 0x02000003 RID: 3
    public partial class Form1 : global::System.Windows.Forms.Form
    {
        // Token: 0x06000048 RID: 72 RVA: 0x00002289 File Offset: 0x00000489
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000049 RID: 73 RVA: 0x00002F80 File Offset: 0x00001180
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape9 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.listView = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox3 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox4 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCheckbox5 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSlider2 = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(839, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(839, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Location = new System.Drawing.Point(249, 590);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(134, 45);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fun Stuff";
            this.groupBox6.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape9});
            this.shapeContainer1.Size = new System.Drawing.Size(912, 527);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape9
            // 
            this.rectangleShape9.BorderColor = System.Drawing.Color.Maroon;
            this.rectangleShape9.FillColor = System.Drawing.Color.Maroon;
            this.rectangleShape9.FillGradientColor = System.Drawing.Color.Maroon;
            this.rectangleShape9.Location = new System.Drawing.Point(-16, 0);
            this.rectangleShape9.Name = "rectangleShape9";
            this.rectangleShape9.Size = new System.Drawing.Size(941, 20);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username});
            this.listView.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.SystemColors.Highlight;
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.HoverSelection = true;
            this.listView.Location = new System.Drawing.Point(12, 37);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(436, 422);
            this.listView.TabIndex = 26;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged_1);
            // 
            // username
            // 
            this.username.Text = "[Current Players]";
            this.username.Width = 443;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(837, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(761, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "─";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Location = new System.Drawing.Point(-36, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 23);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.HideSelection = false;
            this.textBox9.Location = new System.Drawing.Point(47, 6);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(247, 10);
            this.textBox9.TabIndex = 35;
            this.textBox9.Text = "cod cold war zombie tool";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton1.color = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton1.colorActive = System.Drawing.SystemColors.HotTrack;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 13;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 25;
            this.bunifuTileButton1.LabelText = "Save Current Location";
            this.bunifuTileButton1.Location = new System.Drawing.Point(590, 75);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(226, 33);
            this.bunifuTileButton1.TabIndex = 41;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(589, 117);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 42;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange_1);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(614, 119);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(203, 15);
            this.bunifuCustomLabel4.TabIndex = 43;
            this.bunifuCustomLabel4.Text = "Teleport Zombies to Location Saved";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = false;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(589, 172);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 44;
            this.bunifuCheckbox2.OnChange += new System.EventHandler(this.bunifuCheckbox2_OnChange);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(616, 174);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(152, 15);
            this.bunifuCustomLabel1.TabIndex = 45;
            this.bunifuCustomLabel1.Text = "Zombies Ignore All Players";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCheckbox3
            // 
            this.bunifuCheckbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox3.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox3.Checked = false;
            this.bunifuCheckbox3.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCheckbox3.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox3.Location = new System.Drawing.Point(589, 208);
            this.bunifuCheckbox3.Name = "bunifuCheckbox3";
            this.bunifuCheckbox3.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox3.TabIndex = 46;
            this.bunifuCheckbox3.OnChange += new System.EventHandler(this.bunifuCheckbox3_OnChange);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(614, 210);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 15);
            this.bunifuCustomLabel2.TabIndex = 47;
            this.bunifuCustomLabel2.Text = "God Mode";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCheckbox4
            // 
            this.bunifuCheckbox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox4.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox4.Checked = false;
            this.bunifuCheckbox4.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCheckbox4.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox4.Location = new System.Drawing.Point(589, 243);
            this.bunifuCheckbox4.Name = "bunifuCheckbox4";
            this.bunifuCheckbox4.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox4.TabIndex = 48;
            this.bunifuCheckbox4.OnChange += new System.EventHandler(this.bunifuCheckbox4_OnChange);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(614, 246);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(99, 15);
            this.bunifuCustomLabel3.TabIndex = 49;
            this.bunifuCustomLabel3.Text = "Unlimited Ammo";
            // 
            // bunifuCheckbox5
            // 
            this.bunifuCheckbox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox5.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox5.Checked = false;
            this.bunifuCheckbox5.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.bunifuCheckbox5.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox5.Location = new System.Drawing.Point(589, 278);
            this.bunifuCheckbox5.Name = "bunifuCheckbox5";
            this.bunifuCheckbox5.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox5.TabIndex = 50;
            this.bunifuCheckbox5.OnChange += new System.EventHandler(this.bunifuCheckbox5_OnChange);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(615, 280);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(53, 15);
            this.bunifuCustomLabel5.TabIndex = 51;
            this.bunifuCustomLabel5.Text = "Insta Kill";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton2.color = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton2.colorActive = System.Drawing.SystemColors.HotTrack;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 13;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 25;
            this.bunifuTileButton2.LabelText = "Give Maximum Money";
            this.bunifuTileButton2.Location = new System.Drawing.Point(589, 313);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(226, 33);
            this.bunifuTileButton2.TabIndex = 52;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.SystemColors.Highlight;
            this.bunifuSlider1.Location = new System.Drawing.Point(579, 430);
            this.bunifuSlider1.MaximumValue = 50000;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(254, 30);
            this.bunifuSlider1.TabIndex = 53;
            this.bunifuSlider1.Value = 0;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged_1);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(511, 434);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(60, 15);
            this.bunifuCustomLabel6.TabIndex = 54;
            this.bunifuCustomLabel6.Text = "Game XP";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(772, 399);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(60, 13);
            this.bunifuCustomLabel7.TabIndex = 55;
            this.bunifuCustomLabel7.Text = "Max: 5,000";
            // 
            // bunifuSlider2
            // 
            this.bunifuSlider2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider2.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider2.BorderRadius = 0;
            this.bunifuSlider2.IndicatorColor = System.Drawing.SystemColors.Highlight;
            this.bunifuSlider2.Location = new System.Drawing.Point(579, 374);
            this.bunifuSlider2.MaximumValue = 5000;
            this.bunifuSlider2.Name = "bunifuSlider2";
            this.bunifuSlider2.Size = new System.Drawing.Size(254, 30);
            this.bunifuSlider2.TabIndex = 56;
            this.bunifuSlider2.Value = 0;
            this.bunifuSlider2.ValueChanged += new System.EventHandler(this.bunifuSlider2_ValueChanged);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(500, 379);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(72, 15);
            this.bunifuCustomLabel8.TabIndex = 57;
            this.bunifuCustomLabel8.Text = "Weapon XP";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(766, 455);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel9.TabIndex = 58;
            this.bunifuCustomLabel9.Text = "Max: 50,000";
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton3.color = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton3.colorActive = System.Drawing.SystemColors.HotTrack;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = null;
            this.bunifuTileButton3.ImagePosition = 13;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 25;
            this.bunifuTileButton3.LabelText = "Refresh Players";
            this.bunifuTileButton3.Location = new System.Drawing.Point(13, 31);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(435, 31);
            this.bunifuTileButton3.TabIndex = 59;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton4.color = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton4.colorActive = System.Drawing.SystemColors.HotTrack;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = null;
            this.bunifuTileButton4.ImagePosition = 13;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 25;
            this.bunifuTileButton4.LabelText = "Kill Player";
            this.bunifuTileButton4.Location = new System.Drawing.Point(249, 652);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(226, 33);
            this.bunifuTileButton4.TabIndex = 60;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton5.color = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton5.colorActive = System.Drawing.SystemColors.HotTrack;
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = null;
            this.bunifuTileButton5.ImagePosition = 13;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 25;
            this.bunifuTileButton5.LabelText = "Redeem Access Key";
            this.bunifuTileButton5.Location = new System.Drawing.Point(229, 480);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(219, 34);
            this.bunifuTileButton5.TabIndex = 61;
            this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // bunifuTileButton6
            // 
            this.bunifuTileButton6.BackColor = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton6.color = System.Drawing.SystemColors.Highlight;
            this.bunifuTileButton6.colorActive = System.Drawing.SystemColors.HotTrack;
            this.bunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton6.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton6.Image = null;
            this.bunifuTileButton6.ImagePosition = 13;
            this.bunifuTileButton6.ImageZoom = 50;
            this.bunifuTileButton6.LabelPosition = 25;
            this.bunifuTileButton6.LabelText = "Check Time Remaining";
            this.bunifuTileButton6.Location = new System.Drawing.Point(590, 480);
            this.bunifuTileButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuTileButton6.Name = "bunifuTileButton6";
            this.bunifuTileButton6.Size = new System.Drawing.Size(210, 33);
            this.bunifuTileButton6.TabIndex = 62;
            this.bunifuTileButton6.Click += new System.EventHandler(this.bunifuTileButton6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.HintForeColor = System.Drawing.Color.Gray;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox1.LineMouseHoverColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.LineThickness = 3;
            this.textBox1.Location = new System.Drawing.Point(13, 480);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 34);
            this.textBox1.TabIndex = 63;
            this.textBox1.Text = "Free";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(912, 527);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuTileButton6);
            this.Controls.Add(this.bunifuTileButton5);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuTileButton4);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuSlider2);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCheckbox5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCheckbox4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCheckbox3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "exodus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x0400002D RID: 45
        private global::System.ComponentModel.IContainer components;

        // Token: 0x0400002E RID: 46
        private global::System.Windows.Forms.Label label1;

        // Token: 0x0400002F RID: 47
        private global::System.Windows.Forms.Label label2;

        // Token: 0x04000030 RID: 48
        private global::System.Windows.Forms.Button button3;

        // Token: 0x04000031 RID: 49
        private global::System.Windows.Forms.GroupBox groupBox6;

        // Token: 0x04000032 RID: 50
        private global::Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;

        // Token: 0x04000033 RID: 51
        private global::System.Windows.Forms.ListView listView;

        // Token: 0x04000034 RID: 52
        private global::System.Windows.Forms.ColumnHeader username;

        // Token: 0x04000035 RID: 53
        private global::Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape9;

        // Token: 0x04000036 RID: 54
        private global::System.Windows.Forms.Button button5;

        // Token: 0x04000037 RID: 55
        private global::System.Windows.Forms.Button button6;

        // Token: 0x04000038 RID: 56
        private global::System.Windows.Forms.Panel panel1;

        // Token: 0x04000039 RID: 57
        private global::System.Windows.Forms.TextBox textBox9;

        // Token: 0x0400003A RID: 58
        private global::Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;

        // Token: 0x0400003B RID: 59
        private global::Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;

        // Token: 0x0400003C RID: 60
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;

        // Token: 0x0400003D RID: 61
        private global::Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;

        // Token: 0x0400003E RID: 62
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

        // Token: 0x0400003F RID: 63
        private global::Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox3;

        // Token: 0x04000040 RID: 64
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;

        // Token: 0x04000041 RID: 65
        private global::Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox4;

        // Token: 0x04000042 RID: 66
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;

        // Token: 0x04000043 RID: 67
        private global::Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox5;

        // Token: 0x04000044 RID: 68
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;

        // Token: 0x04000045 RID: 69
        private global::Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;

        // Token: 0x04000046 RID: 70
        private global::Bunifu.Framework.UI.BunifuSlider bunifuSlider1;

        // Token: 0x04000047 RID: 71
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;

        // Token: 0x04000048 RID: 72
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;

        // Token: 0x04000049 RID: 73
        private global::Bunifu.Framework.UI.BunifuSlider bunifuSlider2;

        // Token: 0x0400004A RID: 74
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;

        // Token: 0x0400004B RID: 75
        private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;

        // Token: 0x0400004C RID: 76
        private global::Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;

        // Token: 0x0400004D RID: 77
        private global::Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;

        // Token: 0x0400004E RID: 78
        private global::Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;

        // Token: 0x0400004F RID: 79
        private global::Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;

        // Token: 0x04000050 RID: 80
        private global::Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
    }
}