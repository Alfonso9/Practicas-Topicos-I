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
        Type classtype;
        List<StringBuilder> lS;
        List<String> lls;
        Form ff;

        public Reflection()
        {
            lS = new List<StringBuilder>();
            lls = new List<string>();
        }

        public List<StringBuilder> AssemblyExplore()
        {               
            StringBuilder sb = new StringBuilder();
            StringBuilder sm = new StringBuilder();
            Assembly asm = Assembly.LoadFile(@"C:\PracitcasTopicosI\ProyectosVisualStudio2010\Reflection\Estudiante\bin\Debug\Estudiante.dll");
            //sb.Append("FullName: " + asm.FullName + "\n");
            //sb.Append("Location(path): " + asm.Location + "\n");
            classtype = asm.GetType("Estudiante.Estudiante");
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
                    if (p.MemberType.ToString().Equals("Method")) 
                    {
                            sm.Append(p);
                            sm.AppendLine();
                    }
                }
            }
            lS.Add(sb);
            lS.Add(sm);
            //Console.WriteLine(sb);
            return lS;
        }

        public Button buildingForm()
        {
            int loc = 0;
            List<StringBuilder> lS = AssemblyExplore();
            StringBuilder sd = lS[0];
            sd.Replace("System.", "");
            String[] tokens = sd.ToString().Split('\n');
            ff = new Form();
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
                    tb.Name = sP;
                    lls.Add(sP);
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
            String test = lS[1].ToString();
            test.Replace(" ", "\n");            
            Object obj = Activator.CreateInstance(classtype);
            MethodInfo mI = classtype.GetMethod(test.Substring(5, 10));
            List<String> lAttr = new List<string>();
            foreach(Control c in ff.Controls)
            {
                if (c.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                {
                    TextBox t = (TextBox)c;
                    lAttr.Add(t.Text);
                }
            }
            //Object[] oParameters = lAttr.ToArray();
            mI.Invoke(obj, null);
            MessageBox.Show(test.Substring(5, 10));
        }
    }
}
