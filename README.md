# knoledge-monitor

This is the first in hopefully a number of applications built using C# and NBitcoin demonstrating using Bitcoin, the network and the Blockchain.

This application connects to and Monitors nodes on the Bitcoin network. Currently using TestNet the application utilises NBitcoins AddressManager and ChainBehaviour to connect to the Bitcoin network and obtain the Blockchain headers. It includes of the following funtions:

#### Blockchain Headers
A local copy of the Blockchain headers are synchronised with the connected nodes.

#### Know Nodes
A cache of node ip addresses is kept to aid node discovery and connection to the Bitcoin network.

#### Node Connection State
The connection state of each node is monitored and changes reported. The KnoledgeNodeGroup() class extends the NBitcoin NodesGroup(), providing a mechanism to manage event handlers for the nodes in the ConnectedNodes collection.


