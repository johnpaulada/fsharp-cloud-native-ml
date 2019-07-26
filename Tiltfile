docker_build('fsharp-cloud-native-ml', '.')
k8s_yaml('chart/templates/deployment.yaml')
k8s_resource('fsharpml', port_forwards=8080)