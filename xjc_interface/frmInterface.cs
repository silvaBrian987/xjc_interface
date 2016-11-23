using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace xjc_interface
{
    public partial class frmInterface : Form
    {
        private Dictionary<String, String> commandsMap = new Dictionary<string, string>();

        public frmInterface()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmInterface_Load(object sender, EventArgs e)
        {
            cargarChkBoxListParameters();
        }

        private List<String> getParametersList()
        {
            List<String> parameters = new List<string>();
            // parameter : description
            // parameter < arg
            parameters.Add("-nv                :  do not perform strict validation of the input schema(s)");
            parameters.Add("-extension         :  allow vendor extensions - do not strictly follow the. Compatibility Rules and App E.2 from the JAXB Spec");
            parameters.Add("-b <file/dir>      :  specify external bindings files (each <file> must have its own -b). If a directory is given, **/*.xjb is searched");
            parameters.Add("-d <dir>           :  generated files will go into this directory");
            parameters.Add("-p <pkg>           :  specifies the target package");
            parameters.Add("-httpproxy <proxy> :  set HTTP/HTTPS proxy. Format is [user[:password]@]proxyHost:proxyPort");
            parameters.Add("-httpproxyfile <f> :  Works like -httpproxy but takes the argument in a file to protect password ");
            parameters.Add("-classpath <arg>   :  specify where to find user class files");
            parameters.Add("-catalog <file>    :  specify catalog files to resolve external entity references support TR9401, XCatalog, and OASIS XML Catalog format.");
            parameters.Add("-readOnly          :  generated files will be in read-only mode");
            parameters.Add("-npa               :  suppress generation of package level annotations (**/package-info.java)");
            parameters.Add("-no-header         :  suppress generation of a file header with timestamp");
            parameters.Add("-target (2.0|2.1)  :  behave like XJC 2.0 or 2.1 and generate code that doesn't use any 2.2 features.");
            parameters.Add("-enableIntrospection :  enable correct generation of Boolean getters/setters to enable Bean Introspection apis ");
            parameters.Add("-contentForWildcard  :  generates content property for types with multiple xs:any derived elements ");
            parameters.Add("-xmlschema         :  treat input as W3C XML Schema (default)");
            parameters.Add("-relaxng           :  treat input as RELAX NG (experimental,unsupported)");
            parameters.Add("-relaxng-compact   :  treat input as RELAX NG compact syntax (experimental,unsupported)");
            parameters.Add("-dtd               :  treat input as XML DTD (experimental,unsupported)");
            parameters.Add("-wsdl              :  treat input as WSDL and compile schemas inside it (experimental,unsupported)");
            parameters.Add("-verbose           :  be extra verbose");
            parameters.Add("-quiet             :  suppress compiler output");
            parameters.Add("-help              :  display this help message");
            parameters.Add("-version           :  display version information");
            parameters.Add("-fullversion       :  display full version information");
            parameters.Add("-Xinject-code      :  inject specified Java code fragments into the generated code");
            parameters.Add("-Xlocator          :  enable source location support for generated code");
            parameters.Add("-Xsync-methods     :  generate accessor methods with the 'synchronized' keyword");
            parameters.Add("-mark-generated    :  mark the generated code as @javax.annotation.Generated");
            parameters.Add("-episode     :  generate the episode file for separate compilation");
            parameters.Add("-Xpropertyaccessors :  Use XmlAccessType PROPERTY instead of FIELD for generated classes");

            return parameters;
        }

        private Dictionary<String, ParameterItem> getParametersDictionary()
        {
            Dictionary<String, ParameterItem> dic = new Dictionary<String, ParameterItem>();
            foreach (String p in getParametersList())
            {
                ParameterItem param = new ParameterItem();
                String[] strArrayAux = p.Split(':');
                if (strArrayAux[0].Contains('<'))
                {
                    String name = strArrayAux[0];
                    name = name.Substring(0, name.IndexOf('<'));
                    param.setParameter(name.Trim());
                    param.setDescription(strArrayAux[1].Trim());
                    param.hasArgument(true);
                }
                else
                {
                    param.setParameter(strArrayAux[0].Trim());
                    param.setDescription(strArrayAux[1]);
                    param.hasArgument(false);
                }

                dic.Add(param.getParameter(), param);
            }
            return dic;
        }

        private void cargarChkBoxListParameters()
        {
            Dictionary<String, ParameterItem> dic = getParametersDictionary();
            foreach (String key in dic.Keys)
            {
                chkBoxListParameters.Items.Add(key);
            }
        }

        private void chkBoxListParameters_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            String selectedKey = chkBoxListParameters.SelectedItem.ToString();

            Dictionary<String, ParameterItem> dic = getParametersDictionary();
            ParameterItem param = null;
            if (dic.TryGetValue(selectedKey, out param))
            {
                if (!chkBoxListParameters.CheckedItems.Contains(selectedKey))
                {
                    string arg = "";
                    if (param.hasArgument())
                    {
                        arg = Microsoft.VisualBasic.Interaction.InputBox("Description: " + param.getDescription(), param.getParameter() + " argument", "", -1, -1);
                    }
                    commandsMap.Add(param.getParameter(), arg);
                }
                else
                {
                    if (commandsMap.ContainsKey(param.getParameter()))
                    {
                        commandsMap.Remove(param.getParameter());
                    }
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (txtXJCPath.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete XJC path field");
                return;
            }

            if (txtXMLPath.Text.Trim().Equals(""))
            {
                MessageBox.Show("Complete XML path field");
                return;
            }

            string cmdLine = txtXJCPath.Text + " ";

            if (cmdLine.Contains(".jar"))
            {
                cmdLine = "java jar " + cmdLine;
            }

            foreach (String key in commandsMap.Keys)
            {
                string value = "";
                if (commandsMap.TryGetValue(key, out value))
                {
                    cmdLine += key + " " + value + " ";
                }
            }

            cmdLine += " " + txtXMLPath.Text;

            frmLog formLog = new frmLog();

            //MessageBox.Show(cmdLine);
            formLog.Show();
            string result = Utils.ExecuteCommand(cmdLine, false, new DataReceivedEventHandler(new frmLog_ProcOutputHandler(formLog).handler), null);
            //MessageBox.Show("Result: \n" + result);
        }

        private void btnXJCPathPicker_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtXJCPath.Text = openFileDialog.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnXMLPathPicker_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtXMLPath.Text = openFileDialog.FileName;
        }
    }

    class frmLog_ProcOutputHandler
    {
        private frmLog form;

        public frmLog_ProcOutputHandler(frmLog form)
        {
            this.form = form;
        }

        public void handler(object sendingProcess, System.Diagnostics.DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                //form.txtLog.Text += outLine.Data;
                form.AppendLogText(outLine.Data);
            }
        }
    }

    class ParameterItem
    {
        private String parameter;
        private String description;
        private bool argument;

        public ParameterItem()
        {

        }

        public ParameterItem(String parameter, String description, bool argument)
        {
            this.parameter = parameter;
            this.description = description;
            this.argument = argument;
        }

        public String getParameter()
        {
            return parameter;
        }
        public void setParameter(String parameter)
        {
            this.parameter = parameter;
        }
        public String getDescription()
        {
            return description;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public bool hasArgument()
        {
            return argument;
        }
        public void hasArgument(bool argument)
        {
            this.argument = argument;
        }
    }
}
