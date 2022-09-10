using System.Diagnostics;

namespace TextModEditor.Forms;
public partial class DiscordForm : Form
{
    public DiscordForm()
    {
        InitializeComponent();
    }

    private void Discord(object sender, EventArgs e) => Process.Start(new ProcessStartInfo("https://discord.com/invite/bVrUdUJzJe") { UseShellExecute = true });
}
