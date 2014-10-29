using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;


namespace Reflection
{
    class Program
    {
        public static StringBuilder AssemblyExplore()
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

        static void Main(string[] args)
        {
            StringBuilder sd = AssemblyExplore();
            sd.Replace("System.", "");
            String[] tokens = sd.ToString().Split('\n');
            foreach (String s in tokens)
            {                
                String[] token = s.ToString().Split(' ');
                foreach (String ss in token)
                    Console.WriteLine(ss);
            }
            //AssemblyExplore();
            Console.ReadKey();
        }
    }
}
