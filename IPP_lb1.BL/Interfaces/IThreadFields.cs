using System.Windows.Forms;

namespace IPP_lb1.BL
{
    public interface IThreadFields
    {
        TextBox MainTextBox { get; set; }
        TextBox StateTextBox { get; set; }
        TextBox TimeTextBox { get; set; }
    }
}