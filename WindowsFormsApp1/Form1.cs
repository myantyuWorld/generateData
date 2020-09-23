using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var productType = this.txtProduct.Text;
            var cooperation = this.txtCooperation.Text;
            var devCode = this.txtDevCode.Text;
            var actionCode = this.txtActionCode.Text;
            var issueCode = Guid.NewGuid().ToString("N").Substring(0,20);
            var issueTitle = this.txtKadai.Text;
            var actionId = Guid.NewGuid().ToString("P").Substring(0, 20);
            var actionName = $"対策名称_{devCode}_{issueTitle}";
            var actionDesc = this.txtAction.Text;
            var actionStatus = "WOKING";

            var item = new IReporter
            {
                productTypeCode = productType,
                cooperationType = cooperation,
                developmentModel = devCode,
                issueId = issueCode,
                issuekName = issueTitle,
                actionId = actionId,
                actionName = actionName,
                actionDescription = actionDesc,
                actionStatus = actionStatus
            };

            // シリアライズ
            var writer = new StringWriter(); // 出力先のWriterを定義
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(item.GetType());
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            x.Serialize(writer, item, namespaces);

            var xml = writer.ToString();
            Console.WriteLine(xml);
            Console.ReadLine();
        }
    }
}
