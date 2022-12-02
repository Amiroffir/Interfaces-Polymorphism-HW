using System.Security.Cryptography.X509Certificates;

namespace TheIShape
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private IShape[] shapesArr = new IShape[100];
        private int empty = 0;

        private IShape moreVertexes(IShape a, IShape b)
        {
            if (a.getVertexNum() > b.getVertexNum())
                return a;
            else 
                return b;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            // check which boxes are checked and add instaces to the shapesArr
              
            if (checkBox1.Checked)
            {
                    shapesArr[empty] = new Rectangle();
                    empty++;
            }
            if (checkBox2.Checked)
            {
                shapesArr[empty] = new Triangle();
                empty++;
            }
            if (checkBox3.Checked)
            {
                shapesArr[empty] = new Circle();
                empty++;
            }
            if (checkBox4.Checked)
            {
                shapesArr[empty] = new Moon();
                empty++;
            }
            if (checkBox5.Checked)
            {
                shapesArr[empty] = new Elipse();
                empty++;
            }

            // clear the checkboxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            int vertexCount = 0;

            // Add label to the form
            Label label = new Label();
            label.Location = new Point(270, 240);
            label.AutoSize = true;
            this.Controls.Add(label);

            
            for (int i = 0; i < empty; i++)
            {
                vertexCount += shapesArr[i].getVertexNum();
            }
            label.Text = "Overall Vertexes Count: " + vertexCount;
        }
    }
}