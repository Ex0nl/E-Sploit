namespace Esploit
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Inject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute(richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("loadstring(game:HttpGet(\"https://raw.githubusercontent.com/edgeiy/infiniteyield/master/source\"))()");
        }

        private void button6_Click(object sender, EventArgs e) //ESP
        {
            SaladAPI.MainFunctions.Execute("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/WRD%20ESP.txt\"))()");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Infinite%20Jump.txt\"))()");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("loadstring(game:HttpGet(\"https://pastefy.app/wa3v2Vgm/raw\"))()");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Click%20Teleport.txt\"))()");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("game.Players.LocalPlayer.Character.Head:Destroy()\r\nif game.Players.LocalPlayer.Character.Humanoid.Health < 5 then \r\n    local deathmanok = game.Players.LocalPlayer.Character:FindFirstChild(\"HumanoidRootPart\").position\r\n    wait(1.5)\r\n    game.Players.LocalPlayer.Character.HumanoidRootPart.CFrame = CFrame.new(deathmanok)\r\nend");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Dex%20Explorer.txt\"))()");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("loadstring(game:HttpGet(\"https://raw.githubusercontent.com/IlikeyocutgHAH12/FEEGGEG/refs/heads/main/%5BFE%5D%20Energize%20Animation%20Gui.txt\"))()");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("local plr = game.Players.LocalPlayer\r\nlocal chr = plr.Character\r\nlocal hrp = chr.HumanoidRootPart\r\nlocal gui = plr.PlayerGui\r\nprint(gui.Name)\r\nlocal fdf = false\r\nlocal speed = 2.5\r\n\r\nlocal screen = Instance.new(\"ScreenGui\")\r\nscreen.Parent = gui\r\nlocal Victim\r\n\r\nlocal frame = Instance.new(\"Frame\")\r\nframe.Parent = screen\r\nframe.Position = UDim2.new(0.843, 0, 0.781, 0)\r\nframe.Size = UDim2.new(0, 183, 0, 179)\r\n\r\nlocal txtbx = Instance.new(\"TextBox\")\r\ntxtbx.Parent = frame\r\ntxtbx.Position = UDim2.new(0, 0, 0.279, 0)\r\ntxtbx.Size = UDim2.new(0, 183, 0, 50)\r\ntxtbx.Text = \"Username Here\"\r\n\r\nlocal txtbx1 = Instance.new(\"TextBox\")\r\ntxtbx1.Parent = frame\r\ntxtbx1.Position = UDim2.new(0, 0, 0.558, 0)\r\ntxtbx1.Size = UDim2.new(0, 183, 0, 50)\r\ntxtbx1.Text = \"speed\"\r\ntxtbx1.Name = \"TextBox1\"\r\n\r\nlocal txtbtn = Instance.new(\"TextButton\")\r\ntxtbtn.Parent = frame\r\ntxtbtn.Position = UDim2.new(0, 0, 0, 0)\r\ntxtbtn.Size = UDim2.new(0, 183, 0, 50)\r\ntxtbtn.Text = \"Toggle Fuck\"\r\n\r\nlocal A=Instance.new'Animation'\r\nA.AnimationId='rbxassetid://148840371'\r\nlocal H = chr:WaitForChild(\"Humanoid\"):LoadAnimation(A)\r\n\r\ntxtbtn.MouseButton1Click:Connect(function()\r\n\tif fdf == true then\r\n\t\tfdf = false\r\n\t\tH:Stop()\r\n\telse\r\n\t\tfdf = true\r\n\t\tVictim = txtbx.Text\r\n\t\tH:Play()\r\n\t\tH:AdjustSpeed(txtbx1.Text)\r\n\t\tgame:GetService'RunService'.Stepped:Connect(function()\r\n\t\t\tif fdf == true then\r\n\t\t\t\thrp.CFrame=CFrame.new(game.Workspace:FindFirstChild(Victim).HumanoidRootPart.Position)\r\n\t\t\tend\r\n\t\tend)\r\n\tend\r\nend)");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + textBox2.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SaladAPI.MainFunctions.Execute("targetUsername = " + '\"' + textBox3.Text + '\"' + "\r\nplayers = game:GetService(\"Players\")\r\ntargetPlayer = players:FindFirstChild(targetUsername)\r\nplayers.LocalPlayer.Character:MoveTo(targetPlayer.Character.HumanoidRootPart.Position)");
        }
    }
}
