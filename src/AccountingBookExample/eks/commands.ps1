eksctl create cluster `
--name ab-cluster `
--nodegroup-name standard-workers `
--node-type t3.micro
--nodes 3 `
--nodes-min 2 `
--nodes-max 4 `
--node-ami auto