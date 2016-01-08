using NBitcoin.Protocol;
using NBitcoin.Protocol.Behaviors;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Knoledge_Monitor
{
    public partial class FormNodes : Form
    {
        KnoledgeNodesGroup _group;
        CancellationTokenSource _cts = new CancellationTokenSource();

        public FormNodes(KnoledgeNodesGroup group)
        {
            InitializeComponent();
            _group = group;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNodes_Load(object sender, EventArgs e)
        {

        }

        private void FormNodes_Shown(object sender, EventArgs e)
        {
            if (_group == null) return;

            foreach (Node node in _group.ConnectedNodes)
            {
                ListViewItem item = new ListViewItem();

                item.Text = node.RemoteSocketAddress + ":" + node.RemoteSocketPort;
                item.Tag = node;
                listView.Items.Add(item);
            }

            listView.Items[0].Selected = true;
            listView.Select();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cts.Cancel(false);

            if (listView.SelectedItems.Count > 0)
            {
                Node node = listView.SelectedItems[0].Tag as Node;

                if (node != null)
                {
                    textBoxAt.Text = node.ConnectedAt.ToString();

                    if (node.PeerVersion != null)
                    {
                        textBoxHeight.Text = node.PeerVersion.StartHeight.ToString();
                        textBoxVersion.Text = node.PeerVersion.UserAgent;
                    }

                    textBoxSeen.Text = node.LastSeen.LocalDateTime.ToString();

                    var snap = node.Counter.Snapshot();
                    textBoxPerf.Text = snap.ToString();

                    var behavior = node.Behaviors.Find<PingPongBehavior>();

                    if (behavior != null)
                    {
                        int latency = (int)behavior.Latency.TotalMilliseconds; 
                        textBoxLatency.Text = latency.ToString();

                        behavior.Probe();
                    }
                }
                else
                {
                    textBoxAt.Text = "";
                    textBoxHeight.Text = "";
                    textBoxLatency.Text = "";
                    textBoxSeen.Text = "";
                    textBoxPerf.Text = "";
                    textBoxVersion.Text = "";
                }
            }
        }
    }
}
