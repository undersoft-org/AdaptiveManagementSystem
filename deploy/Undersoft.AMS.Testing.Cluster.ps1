kubectl label namespace kube-system admission.kubemod.io/ignore=true --overwrite
kubectl apply -f https://raw.githubusercontent.com/kubemod/kubemod/v0.20.0/bundle.yaml

kubectl label nodes us-dev-lab-server-0 disktype=ssd
kubectl apply -f Undersoft.AMS.Testing.Cluster.yml