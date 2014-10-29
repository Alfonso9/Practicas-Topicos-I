using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

namespace ReflectionStudent
{
    class Reflection
    {
        public Reflection()
        { 
        }

        public StringBuilder AssemblyExplore()
        {
            StringBuilder sb = new StringBuilder();
            Assembly asm = Assembly.LoadFile(@"C:\Users\Alfonso\Documents\visual studio 2010\Projects\Reflection\Estudiante\bin\Debug\Estudiante.dll");
            //sb.Append("FullName: " + asm.FullName + "\n");
            //sb.Append("Location(path): " + asm.Location + "\n");
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
            {
                sb.Append(t + "\n");
                MemberInfo[] po = t.GetMembers();
                foreach (MemberInfo p in po)
                {
                    if (p.ReflectedType.ToString().Equals("Estudiante.Estudiante"))
                        if (p.MemberType.ToString().Equals("Property"))
                        {
                            sb.Append(p);
                            sb.AppendLine();
                        }
                }
            }
            //Console.WriteLine(sb);
            return sb;
        }

        public Button buildingForm()
        {
            int loc = 0;
            StringBuilder sd = AssemblyExplore();
            sd.Replace("System.", "");
            String[] tokens = sd.ToString().Split('\n');
            Form ff = new Form();
            ff.Show();
            foreach (String s in tokens)
            {
                String[] token = s.ToString().Split(' ');
                if (token[0].Equals("String"))
                {
                    Label lb = new Label();
                    String sP = token[1].Replace("\r",": ");
                    lb.Text = sP;
                    lb.Location = new Point(40, 52+loc);
                    TextBox tb = new TextBox();
                    tb.Location = new Point(100, 50+loc);
                    ff.Controls.Add(tb);
                    ff.Controls.Add(lb);            
                    loc += 30;
                }
            }
            Button bt = new Button();
            bt.Text = "Guardar";
            bt.Name = "guardar";
            bt.Location = new Point(100, 60 + loc);
            bt.Click += new EventHandler(test);
            ff.Controls.Add(bt);
            return bt;
        }

        protected void test(Object sender, EventArgs e)
        {
            MessageBox.Show("aaaaaaa");
        }
    }
}
