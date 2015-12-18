﻿using NBitcoin;
using NBitcoin.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Knoledge_Monitor
{
    public class KnoledgeNodesGroup : NodesGroup, IDisposable
    {
        bool _disposed = false;
        CancellationTokenSource _cts = new CancellationTokenSource();
        NodesCollection _nodes = new NodesCollection();

        public KnoledgeNodesGroup(
            Network network,
            NodeConnectionParameters connectionParameters = null,
            NodeRequirement requirements = null)
            : base(network, connectionParameters, requirements)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                while (!_cts.IsCancellationRequested)
                {
                    foreach (Node node in this.ConnectedNodes)
                    {
                        if (!_nodes.Contains(node))
                        {
                            _nodes.Add(node);
                            AddHandlers(node);
                            StateChanged(node, NodeState.Offline);
                        }
                    }
                    Thread.Sleep(50);
                }
            }, _cts.Token);
        }

        public NodeStateEventHandler StateChanged { get; set; }
        public NodeEventHandler Disconnected { get; set; }
        public NodeEventMessageIncoming MessageReceived { get; set; }

        public bool IsConnected
        {
            get
            {
                return _nodes.Any(n => n.State == NodeState.Connected ||
                                            n.State == NodeState.HandShaked);
            }
        }

        public Node ConnectedNode
        {
            get
            {
                return _nodes.FirstOrDefault(n => n.State == NodeState.Connected ||
                                                    n.State == NodeState.HandShaked);
            }
        }

        private void AddHandlers(Node node)
        {
            if (StateChanged != null)
            {
                node.StateChanged += StateChanged;
            }

            if (Disconnected != null)
            {
                node.Disconnected += Disconnected;
            }

            if (MessageReceived != null)
            {
                node.MessageReceived += MessageReceived;
            }
        }


        private void RemoveHandlers(Node node)
        {
            if (StateChanged != null)
            {
                node.StateChanged -= StateChanged;
            }

            if (Disconnected != null)
            {
                node.Disconnected -= Disconnected;
            }

            if (MessageReceived != null)
            {
                node.MessageReceived -= MessageReceived;
            }
        }


        #region IDisposable Members

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            base.Dispose();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _cts.Cancel();
                foreach (Node node in _nodes)
                {
                    RemoveHandlers(node);
                }

                _nodes.Clear();
            }

            _disposed = true;
        }

        #endregion
    }
}
