using System.Windows.Forms;

namespace RoslynCompiler
{
    public class Build
    {
        public Build(string Title, string Message, string FileName, string Icon, ComboBox Combo, Label Status)
        {
            this.BoxTitle = Title;
            this.BoxMessage = Message;
            this.BoxFileName = FileName;
            this.BoxIcon = Icon;
            this.BoxCombo = Combo;
            this.BoxStatus = Status;
        }

        public string BoxTitle { get; set; }
        public string BoxMessage { get; set; }
        public string BoxFileName { get; set; }
        public string BoxIcon { get; set; }
        public ComboBox BoxCombo { get; set; }
        public Label BoxStatus { get; set; }
    }
}