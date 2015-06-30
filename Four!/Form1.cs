using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Four_
{
    public partial class Form1 : Form
    {
        int timer = 75;
        bool fake,fake1;
        int nodes = 0;
        int l = 0;
        List<Node> frige = new List<Node>();
        public Form1(bool color)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
             fake = color;
        }

        delegate void think();
        delegate void time();
        delegate void progress();

        List<PictureBox> one = new List<PictureBox>();
        List<PictureBox> two = new List<PictureBox>();
        List<PictureBox> three = new List<PictureBox>();
        List<PictureBox> forth = new List<PictureBox>();
        List<PictureBox> five = new List<PictureBox>();
        List<PictureBox> six = new List<PictureBox>();
        List<PictureBox> seven = new List<PictureBox>();
        List<PictureBox> eight = new List<PictureBox>();
        List<PictureBox> nine = new List<PictureBox>();
        List<PictureBox> ten = new List<PictureBox>();
        List<PictureBox> eleven = new List<PictureBox>();
        List<PictureBox> twelve = new List<PictureBox>();
        List<List<PictureBox>> allh = new List<List<PictureBox>>();
        List<List<PictureBox>> allv = new List<List<PictureBox>>();
        List<List<PictureBox>> alld = new List<List<PictureBox>>();
        List<List<PictureBox>> allb = new List<List<PictureBox>>();
               
        List<PictureBox> h1 = new List<PictureBox>();
        List<PictureBox> h2 = new List<PictureBox>();
        List<PictureBox> h3 = new List<PictureBox>();
        List<PictureBox> h4 = new List<PictureBox>(); 
        List<PictureBox> h5 = new List<PictureBox>();
        List<PictureBox> h6 = new List<PictureBox>();
        
        List<PictureBox> v1 = new List<PictureBox>();
        List<PictureBox> v2 = new List<PictureBox>();
        List<PictureBox> v3 = new List<PictureBox>();
        List<PictureBox> v4 = new List<PictureBox>();
        List<PictureBox> v5 = new List<PictureBox>();
        List<PictureBox> v6 = new List<PictureBox>();
        List<PictureBox> v7 = new List<PictureBox>();

        List<PictureBox> d1 = new List<PictureBox>();
        List<PictureBox> d2 = new List<PictureBox>();
        List<PictureBox> d3 = new List<PictureBox>();
        List<PictureBox> d4 = new List<PictureBox>();
        List<PictureBox> d5 = new List<PictureBox>();
        List<PictureBox> d6 = new List<PictureBox>();

        List<PictureBox> b1 = new List<PictureBox>();
        List<PictureBox> b2 = new List<PictureBox>();
        List<PictureBox> b3 = new List<PictureBox>();
        List<PictureBox> b4 = new List<PictureBox>();
        List<PictureBox> b5 = new List<PictureBox>();
        List<PictureBox> b6 = new List<PictureBox>();

        
        Image replace = Resource1.RedC;
        int count = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {


            one.Add(pictureBox19); one.Add(pictureBox13); one.Add(pictureBox7); one.Add(pictureBox1);
            two.Add(pictureBox20); two.Add(pictureBox14); two.Add(pictureBox8); two.Add(pictureBox2);
            three.Add(pictureBox21); three.Add(pictureBox15); three.Add(pictureBox9); three.Add(pictureBox3);
            forth.Add(pictureBox22); forth.Add(pictureBox16); forth.Add(pictureBox10); forth.Add(pictureBox4);
            five.Add(pictureBox23); five.Add(pictureBox17); five.Add(pictureBox11); five.Add(pictureBox5);
            six.Add(pictureBox24); six.Add(pictureBox18); six.Add(pictureBox12); six.Add(pictureBox6);

            seven.Add(pictureBox19); seven.Add(pictureBox25); seven.Add(pictureBox31); seven.Add(pictureBox37);
            eight.Add(pictureBox20); eight.Add(pictureBox26); eight.Add(pictureBox32); eight.Add(pictureBox38);
            nine.Add(pictureBox21); nine.Add(pictureBox27); nine.Add(pictureBox33); nine.Add(pictureBox39);
            ten.Add(pictureBox22); ten.Add(pictureBox28); ten.Add(pictureBox34); ten.Add(pictureBox40);
            eleven.Add(pictureBox23); eleven.Add(pictureBox29); eleven.Add(pictureBox35); eleven.Add(pictureBox41);
            twelve.Add(pictureBox24); twelve.Add(pictureBox30); twelve.Add(pictureBox36); twelve.Add(pictureBox42);

            h1.Add(pictureBox1); h1.Add(pictureBox7); h1.Add(pictureBox13); h1.Add(pictureBox19); h1.Add(pictureBox25); h1.Add(pictureBox31); h1.Add(pictureBox37);
            h2.Add(pictureBox2); h2.Add(pictureBox8); h2.Add(pictureBox14); h2.Add(pictureBox20); h2.Add(pictureBox26); h2.Add(pictureBox32); h2.Add(pictureBox38);
            h3.Add(pictureBox3); h3.Add(pictureBox9); h3.Add(pictureBox15); h3.Add(pictureBox21); h3.Add(pictureBox27); h3.Add(pictureBox33); h3.Add(pictureBox39);
            h4.Add(pictureBox4); h4.Add(pictureBox10); h4.Add(pictureBox16); h4.Add(pictureBox22); h4.Add(pictureBox28); h4.Add(pictureBox34); h4.Add(pictureBox40);
            h5.Add(pictureBox5); h5.Add(pictureBox11); h5.Add(pictureBox17); h5.Add(pictureBox23); h5.Add(pictureBox29); h5.Add(pictureBox35); h5.Add(pictureBox41);
            h6.Add(pictureBox6); h6.Add(pictureBox12); h6.Add(pictureBox18); h6.Add(pictureBox24); h6.Add(pictureBox30); h6.Add(pictureBox36); h6.Add(pictureBox42);

            v1.Add(pictureBox1); v1.Add(pictureBox2); v1.Add(pictureBox3); ; v1.Add(pictureBox4); v1.Add(pictureBox5); v1.Add(pictureBox6);
            v2.Add(pictureBox7); v2.Add(pictureBox8); v2.Add(pictureBox9); ; v2.Add(pictureBox10); v2.Add(pictureBox11); v2.Add(pictureBox12);
            v3.Add(pictureBox13); v3.Add(pictureBox14); v3.Add(pictureBox15);  v3.Add(pictureBox16); v3.Add(pictureBox17); v3.Add(pictureBox18);
            v4.Add(pictureBox19); v4.Add(pictureBox20); v4.Add(pictureBox21);  v4.Add(pictureBox22); v4.Add(pictureBox23); v4.Add(pictureBox24);
            v5.Add(pictureBox25); v5.Add(pictureBox26); v5.Add(pictureBox27);  v5.Add(pictureBox28); v5.Add(pictureBox29); v5.Add(pictureBox30);
            v6.Add(pictureBox31); v6.Add(pictureBox32); v6.Add(pictureBox33);  v6.Add(pictureBox34); v6.Add(pictureBox35); v6.Add(pictureBox36);
            v7.Add(pictureBox37); v7.Add(pictureBox38); v7.Add(pictureBox39);  v7.Add(pictureBox40); v7.Add(pictureBox41); v7.Add(pictureBox42);

            d1.Add(pictureBox4); d1.Add(pictureBox9); d1.Add(pictureBox14); d1.Add(pictureBox19);
            d2.Add(pictureBox5); d2.Add(pictureBox10); d2.Add(pictureBox15); d2.Add(pictureBox20); d2.Add(pictureBox25);
            d3.Add(pictureBox6); d3.Add(pictureBox11); d3.Add(pictureBox16); d3.Add(pictureBox21); d3.Add(pictureBox26); d3.Add(pictureBox31);
            d4.Add(pictureBox12); d4.Add(pictureBox17); d4.Add(pictureBox22); d4.Add(pictureBox27); d4.Add(pictureBox32); d4.Add(pictureBox37);
            d5.Add(pictureBox18); d5.Add(pictureBox23); d5.Add(pictureBox28); d5.Add(pictureBox33); d5.Add(pictureBox38);
            d6.Add(pictureBox24); d6.Add(pictureBox29); d6.Add(pictureBox34); d6.Add(pictureBox39);

            b1.Add(pictureBox40); b1.Add(pictureBox33); b1.Add(pictureBox26); b1.Add(pictureBox19);
            b2.Add(pictureBox41); b2.Add(pictureBox34); b2.Add(pictureBox27); b2.Add(pictureBox20); b2.Add(pictureBox13);
            b3.Add(pictureBox42); b3.Add(pictureBox35); b3.Add(pictureBox28); b3.Add(pictureBox21); b3.Add(pictureBox14); d3.Add(pictureBox7);
            b4.Add(pictureBox36); b4.Add(pictureBox29); b4.Add(pictureBox22); b4.Add(pictureBox15); b4.Add(pictureBox8); d4.Add(pictureBox1);
            b5.Add(pictureBox30); b5.Add(pictureBox23); b5.Add(pictureBox16); b5.Add(pictureBox9); b5.Add(pictureBox2);
            b6.Add(pictureBox24); b6.Add(pictureBox17); b6.Add(pictureBox10); b6.Add(pictureBox3);

            allh.Add(h1); allh.Add(h2); allh.Add(h3); allh.Add(h4); allh.Add(h5); allh.Add(h6);
            allv.Add(v1); allv.Add(v2); allv.Add(v3); allv.Add(v4); allv.Add(v5); allv.Add(v6); allv.Add(v7);
            alld.Add(d1); alld.Add(d2); alld.Add(d3); alld.Add(d4); alld.Add(d5); alld.Add(d6);
            allb.Add(b1); allb.Add(b2); allb.Add(b3); allb.Add(b4); allb.Add(b5); allb.Add(b6);
            int[,] curr = getCurrentstate();
            displaySate(curr);

            if(fake) {
                fake = !fake;
                disableall();
                think solo = aimove;
                solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
            }
            textBox1.Enabled = false;
            textBox1.Text="Game Started";
            time rush = changetimer;
            rush.BeginInvoke(new AsyncCallback(gettime), (int)timer);
        }
        public void changetimer()
        {
            while (timer > -1)
            {
                Thread.Sleep(1000);
                timer--;
                label8.Text = timer.ToString();
                label8.Refresh();
                if(timer == 0) {
                    if (fake) {
                    MessageBox.Show("Blue Player Lost");
                    } else {
                    MessageBox.Show("Red Player Lost");
                    }
                    this.Close();
                    break;
                }
            }         
        }
        public void gettime(IAsyncResult timeresult)
        {
            int newtime = (int)timeresult.AsyncState;
            return;
        }
        public void changepic(List<PictureBox> ch)
        {
            timer = 75;
            if (ch[3].Tag.Equals("1")||ch[3].Tag.Equals("-1"))
            {
                if (!fake) { MessageBox.Show("Red Lost"); } else { MessageBox.Show("Blue Lost"); }
                this.Close();
            }
             else if (fake)
            {
                replace = Resource1.BlueC;
                fake = false; 
                fake1 = fake;
                Form1.ActiveForm.Activate();
                Form1.ActiveForm.Text = "Four! Red's Turn";
            }
            else
            {
                    replace = Resource1.RedC;
                    fake = true;
                    fake1 = fake;
                    Form1.ActiveForm.Activate();
                    Form1.ActiveForm.Text = "Four! Blue's Turn";
            }
            for (int c = 0; c < 4; c++)
            {
                if (ch[c].Tag.Equals("0"))
                {
                    if(fake) {
                    ch[c].Tag = "1";
                    } else {
                    ch[c].Tag = "-1";
                    }
                    ch[c].Image = replace;
                    break;
                }
            }
            
        }
        public void check()
        {
            int blue = 0;
            int red = 0;
            for(int f = 0; f<allh.Count;f++) {
                List<PictureBox> temp = allh[f];
                for (int s = 0; s < temp.Count;s++ )
                {
                    switch (temp[s].Tag.ToString()) {
                        case "-1": blue++;
                            red = 0;
                            if (blue == 4) { MessageBox.Show("Blue Wins"); this.Close(); break; }
                            break;
                        case "1": red++;
                            blue = 0;
                            if (red == 4) { MessageBox.Show("Red Wins"); this.Close(); break; }
                            break;
                        case "0": red = 0;
                            blue = 0;
                            break;
                    }                                 
                }
                blue = 0;
                red = 0;
            }
            blue = 0;
             red = 0;
            for (int f = 0; f < allv.Count; f++)
            {
                List<PictureBox> temp = allv[f];
                for (int s = 0; s < temp.Count; s++)
                {
                    switch (temp[s].Tag.ToString())
                    {
                        case "-1": blue++;
                            red = 0;
                            if (blue == 4) { MessageBox.Show("Blue Wins"); this.Close(); break; }
                            break;
                        case "1": red++;
                            blue = 0;
                            if (red == 4) { MessageBox.Show("Red Wins"); this.Close(); break; }
                            break;
                        case "0": red = 0;
                            blue = 0;
                            break;
                    }                                   
                }
                blue = 0;
                red = 0;
            }
            
            for (int f = 0; f < alld.Count; f++)
            {
                List<PictureBox> temp = alld[f];
                for (int s = 0; s < temp.Count; s++)
                {
                    switch (temp[s].Tag.ToString())
                    {
                        case "-1": blue++;
                            red = 0;
                            if (blue == 4) { MessageBox.Show("Blue Wins"); this.Close(); break; }
                            break;
                        case "1": red++;
                            blue = 0;
                            if (red == 4) { MessageBox.Show("Red Wins"); this.Close(); break; }
                            break;
                        case "0": red = 0;
                            blue = 0;
                            break;
                    }
                }
                blue = 0;
                red = 0;
            }
            for (int f = 0; f < allb.Count; f++)
            {
                List<PictureBox> temp = allb[f];
                for (int s = 0; s < temp.Count; s++)
                {
                    switch (temp[s].Tag.ToString())
                    {
                        case "-1": blue++;
                            red = 0;
                            if (blue == 4) { MessageBox.Show("Blue Wins"); this.Close(); break; }
                            break;
                        case "1": red++;
                            blue = 0;
                            if (red == 4) { MessageBox.Show("Red Wins"); this.Close(); break; }
                            break;
                        case "0": red = 0;
                            blue = 0;
                            break;
                    }
                }
                blue = 0;
                red = 0;
            }
            count++;
            if (count == 42)
            {
                MessageBox.Show("Draw!");
                this.Close();
            }
        }
        public int[,] getCurrentstate(){
            int[,] state = new int[6, 7];
            int i = 0, j = 0;
            foreach (List<PictureBox> test in allh)
            {
                j = 0;
                foreach (PictureBox set in test)
                {
                    state[i, j] = Int32.Parse(set.Tag.ToString());
                    j++;
                }
                i++;
            }
            return state;
        }
        public void displaySate(int[,] list)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    System.Console.Write(list[i, j]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
            return;
        }
        Node parent = new Node();

        public void aimove()
        {
            progressBar1.Value = 0;
            parent.setState(getCurrentstate());
            parent = futuremove(parent);               // create tree lvl 2
            System.Console.WriteLine("Level 2 done");
            fake1 = !fake1;
            int f = 0;
            List<Node> lvlfour= new List<Node>();
            foreach(Node child in parent.getChildren()) {     // create tree lvl 3
                Node childz = futuremove(child);
                lvlfour.Add(childz);
                f++;
                System.Console.WriteLine("Child "+f+" Done");
            }
            System.Console.WriteLine("Level 3 done");

            f = 0;
            fake1 = !fake1;
            List<List<Node>> terminalsets = new List<List<Node>>();  
            foreach (Node child in lvlfour)                
            {
                foreach (Node childs in child.getChildren())          // create tree 4
                {
                    Node childz = futuremove(childs);
                    f++;
                    terminalsets.Add(childz.getChildren());
                    System.Console.WriteLine("Child " + f + " Done");
                }
            }
            System.Console.WriteLine("Level 4 done");
            
            fake1 = fake;
            foreach(List<Node> first in terminalsets) {            // propagate terminals nodes(lvl 4) to lvl 3
                foreach(Node second in first) {
                    Node wer = getValue(second);
                    if (fake1) // MAX
                    {
                        if (wer.getParent().getValue() < wer.getValue()) {
                            Node up = wer.getParent();
                            up.setValue(wer.getValue());
                        }
                    }
                    else //MIN
                    {
                        if (wer.getParent().getValue() > wer.getValue())
                        {
                            Node up = wer.getParent();
                            up.setValue(wer.getValue());
                        }
                    }
                }
            }
            fake1 = !fake1;
            foreach (Node child in lvlfour)                           // propagate lvl 3 values to lvl 2
            {
                foreach (Node childs in child.getChildren())
                {
                    if(fake1) { //MIN
                        if (child.getValue() > childs.getValue())
                        {
                            child.setValue(childs.getValue());
                        }
                    } else {    //MAX
                        if (child.getValue() < childs.getValue())
                        {
                            child.setValue(childs.getValue());
                        }
                    }
                }
            }
            fake1 = !fake1;
            int decision;
            if (fake1)                                           
            {
                decision = -1;
            }
            else
            {
                decision = 13;
            }
            for(int i =0; i< parent.getChildren().Count;i++)              // select move which is best
            {
                Node child = parent.getChildren()[i];
                if(fake1) //MAX
                {
                    if (decision <= child.getValue())
                    {
                        decision = i+1;
                    }
                }
                else //MIN
                {
                    if (decision >= child.getValue())
                    {
                        decision = i + 1;
                    }
                }
            }
            switch (decision)
            {
                case 1: changepic(one);
                    textBox1.AppendText("\t\t" + "Computer's Move was 1");
                    break;
                case 2: changepic(two);
                    textBox1.AppendText("\t\t" + " Computer's Move was 2");

                    break;
                case 3: changepic(three);
                    textBox1.AppendText("\t\t" + " Computer's Move was 3");

                    break;
                case 4: changepic(forth);
                    textBox1.AppendText("\t\t" + " Computer's Move was 4");

                    break;
                case 5: changepic(five);
                    textBox1.AppendText("\t\t" + " Computer's Move was 5");

                    break;
                case 6: changepic(six);
                    textBox1.AppendText("\t\t" + " Computer's Move was 6");

                    break;
                case 7: changepic(seven);
                    textBox1.AppendText("\t\t" + " Computer's Move was 7");

                    break;
                case 8: changepic(eight);
                    textBox1.AppendText("\t\t" + " Computer's Move was 8");

                    break;
                case 9: changepic(nine);
                    textBox1.AppendText("\t\t" + " Computer's Move was 9");

                    break;
                case 10: changepic(ten);
                    textBox1.AppendText("\t\t" + " Computer's Move was 10");

                    break;
                case 11: changepic(eleven);
                    textBox1.AppendText("\t\t" + " Computer's Move was 11");

                    break;
                case 12: changepic(twelve);
                    textBox1.AppendText("\t\t" + " Computer's Move was 12");

                    break;
            }
            check();
            enableall();
            nodes = 0;
            indi = 0;
            
        }
        public Node getValue(Node set)
        {
            int[,] get = set.getState();
            int hor = 0;
            for (int i = 0; i < 6; i++)               //get all horizontal values
            {
                    for (int j = 0; j < 7; j++)
                    {
                        hor = hor + get[i, j]; 
                    }
            }
            int  ver = 0;
            for (int i = 0; i < 7; i++)            // get all vertical values
            {
                for (int j = 0; j < 6; j++)
                {
                    ver = ver + get[j, i];
                }
            }
            int d1 = 0;
            for (int i = 0; i < 6; i++)              // get all diagonal to the right vales
            {
                for (int j = 0; j < 7; j++)
                {
                    if ((i == 3 && j == 0) || (i == 4 && j == 0) || (i == 5 && j == 0) || (i == 4 && j == 1) || (i == 5 && j == 1) || (i == 5 && j == 2) || (i == 0 && j == 4) || (i == 0 && j == 5) || (i == 0 && j == 6) || (i == 1 && j == 5) || (i == 1 && j == 6) || (i == 2 && j == 6))
                    {
                    }
                    else
                    {
                        d1 = d1 + get[i, j];
                    }
                }
            }
            int d2 = 0;
            for (int i = 0; i < 6; i++)            //get all diagonal to the left values
            {
                for (int j = 0; j < 7; j++)
                {
                    if ((i == 0 && j == 0) || (i == 0 && j == 1) || (i == 0 && j == 2) || (i == 1 && j == 0) || (i == 1 && j == 1) || (i == 2 && j == 0) || (i == 3 && j == 6) || (i == 4 && j == 5) || (i == 4 && j == 6) || (i == 5 && j == 4) || (i == 5 && j == 5) || (i == 5 && j == 6))
                    {
                    }
                    else
                    {
                        d1 = d1 + get[i, j];
                    }
                }
            }
            set.setValue(ver + hor + d1 + d2);
            return set;
        }
        public void getresult(IAsyncResult result)
        {       
            Node parent = (Node)result.AsyncState;
            return;
        }
        public Node fillrest(int[,] current, int outer, int inner)
        {
            int[,] child = new int[6, 7];
            Node son = new Node();
            for (int k = 0; k < 6; k++)
            {
                for (int l = 0; l < 7; l++)
                {
                    if (outer == k && inner == l)
                    {
                        if (!fake1)
                        {
                            child[outer, inner] = 1;
                        }
                        else
                        {
                            child[outer, inner] = -1;
                        }                      
                    }
                    else
                    {
                        child[k, l] = current[k,l];
                    }
                }
            }
            
            son.setState(child);
            frige.Add(son);
            return son;
        }
        public Node futuremove(Node mother)
        {
            int[,] curr = mother.getState();
            List<Node> children = new List<Node>();
            bool first = true;
            //for buttons 1-6 only
            for (int i = 0; i < 6; i++)
            {
                first = true;
                for (int j = 3; j > -1; j--)
                {
                    if (curr[i, j] == 0 && first && curr[i, 0] == 0)
                    {
                        first = false;                        
                        children.Add(fillrest(curr,i,j));
                    }
                }
            }
            //for buttons 7-12 only
            first = true;
            for (int i = 0; i < 6; i++)
            {
                first = true;
                for (int j = 3; j < 7; j++)
                {
                    if (curr[i, j] == 0 && first && curr[i,6] == 0)
                    {
                        first = false;
                        children.Add(fillrest(curr, i, j));
                    }
                }
            }
            if(children.Count>0) {
                foreach (Node daughter in children)
                {
                    daughter.setParent(mother);                  
                    nodes++;
                    l++;
                    if (l == 19)
                    {
                        l = 0;
                        progress grow = changeprogress;
                        grow.BeginInvoke(new AsyncCallback(getprogress), (int)nodes);
                    }
                    System.Console.WriteLine(nodes);
                    displaySate(daughter.getState());
                }
            }
            mother.setChildren(children);
            return mother;
        }
        int indi = 0;
        public void changeprogress()
        {
            indi++;
            if (indi == 99)
            {
                indi = 100;
            }
            label10.Text = indi.ToString() + "%";
            label10.Refresh();
            progressBar1.Increment(1);
            progressBar1.Refresh();
            return;
        }
        public void getprogress(IAsyncResult prog)
        {
            return;
        }
        public void disableall()
        {
            One.Enabled = false;
            Two.Enabled = false;
            Three.Enabled = false;
            Four.Enabled = false;
            Five.Enabled = false;
            Six.Enabled = false;
            Seven.Enabled = false;
            Eight.Enabled = false;
            Nine.Enabled = false;
            Ten.Enabled = false;
            Eleven.Enabled = false;
            Twelve.Enabled = false;
        }
        public void enableall()
        {
            One.Enabled = true;
            Two.Enabled = true;
            Three.Enabled = true;
            Four.Enabled = true;
            Five.Enabled = true;
            Six.Enabled = true;
            Seven.Enabled = true;
            Eight.Enabled = true;
            Nine.Enabled = true;
            Ten.Enabled = true;
            Eleven.Enabled = true;
            Twelve.Enabled = true;
        }

        private void One_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t"+"Your Move was 1");
            disableall();
            changepic(one);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 7");
            disableall();
            changepic(seven);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Two_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 2");
            disableall();
            changepic(two);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 8");
            disableall();
            changepic(eight);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 3");
            disableall();
            changepic(three);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 9");
            disableall();
            changepic(nine);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 4");
            disableall();
            changepic(forth);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Ten_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 10");
            disableall();
            changepic(ten);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 5");
            disableall();
            changepic(five);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Eleven_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 11");
            disableall();
            changepic(eleven);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 6");
            disableall();
            changepic(six);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

        private void Twelve_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\t\t" + "Your Move was 12");
            disableall();
            changepic(twelve);
            check();
            think solo = aimove;
            solo.BeginInvoke(new AsyncCallback(getresult), (Node)parent);
        }

    }
    public class Node
    {
        private Node parent = null;
        private List<Node> children = new List<Node>();
        private int[,] state = new int[6,7];
        private int value = 0;
        public void setParent(Node parent) {
            this.parent = parent;
            return;
        }
        public void setChildren(List<Node> children)
        {
            this.children = children;
            return;
        }
        public void setState(int[,] state)
        {
            this.state = state;
            return;
        }
        public void setValue(int value)
        {
            this.value = value;
            return;
        }
        public Node getParent()
        {
            return this.parent;
        }
        public List<Node> getChildren()
        {
            return this.children;
        }
        public int[,] getState()
        {
            return this.state;
        }
        public int getValue() {
            return this.value;
        }
    }
}