# knoledge-monitor

This is the first of hopefully a number of applications using C# and NBitcoin. Please bear in mind this is not production code and is just some examples of how to use the NBitcoin API.

This application connects to and monitors nodes on the Bitcoin network. Currently using TestNet the application utilises NBitcoins AddressManager and ChainBehaviour to connect to the Bitcoin network and obtain the Blockchain headers. It includes of the following funtions:

#### Blockchain Headers
A local copy of the Blockchain headers are synchronised with the connected nodes.

#### Node Connection State
The connection state of each node is monitored and changes reported. The KnoledgeNodeGroup() class extends the NBitcoin NodesGroup(), providing a mechanism to manage event handlers for the nodes in the ConnectedNodes collection.


