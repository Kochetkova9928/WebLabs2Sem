using System.Linq;

namespace WebLabs.Models
{
    public class ResultModel
    {
        public string Title { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }

        public ResultModel(TextBoxModel model)
        {
            Title = "TextBox";
            Property = "Text";
            Value = model.Text;
        }

        public ResultModel(TextAreaModel model)
        {
            Title = "TextArea";
            Property = "Text";
            Value = model.Text;
        }

        public ResultModel(CheckBoxModel model)
        {
            Title = "CheckBox";
            Property = "IsSelected";
            Value = model.Checked.ToString();
        }

        public ResultModel(RadioModel model)
        {
            Title = "Radio";
            Property = "Month";
            Value = model.Month.ToString();
        }

        public ResultModel(DropDownListModel model)
        {
            Title = "DropDownList";
            Property = "Month";
            Value = model.Month.ToString();
        }

        public ResultModel(ListBoxModel model)
        {
            Title = "ListBox";
            Property = "Months";
            Value = string.Join(", ", model.Months.Select(x => x.ToString()));
        }
    }
}
