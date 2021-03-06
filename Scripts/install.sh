#! /bin/sh

# Example install script for Unity3D project. See the entire example: https://github.com/JonathanPorta/ci-build

# This link changes from time to time. I haven't found a reliable hosted installer package for doing regular
# installs like this. You will probably need to grab a current link from: http://unity3d.com/get-unity/download/archive
curl -o "/tmp/mdk.pkg" -fL http://download.mono-project.com/archive/mdk-latest.pkg
sudo installer -dumplog -package "/tmp/mdk.pkg" -target /

echo 'Downloading from http://netstorage.unity3d.com/unity/649f48bbbf0f/MacEditorInstaller/Unity-5.4.1f1.pkg '
curl -o Unity.pkg http://netstorage.unity3d.com/unity/649f48bbbf0f/MacEditorInstaller/Unity-5.4.1f1.pkg

echo 'Installing Unity.pkg'
sudo installer -dumplog -package Unity.pkg -target /