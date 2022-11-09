# VR-Sync
Test360.mp4 NOT included

## Setup Notes:
1. The Video Player scene is found in Assets/Scenes
2. In Edit -> Project Settings -> Player, select Android tab. Go under Other Setting and scroll down to Configuration. Make sure to compile using IL2CPP and under "Internet Access", set it to "Require"
3. In Edit -> Project Settings, make sure there XR Plug-in Management is installed. In this setting make sure to go into Android and check Ocuclus
4. In Heirarchy, Video Player object has  2 Children: Video Manager and Network Manager. You may change the the URI of the master client in the Network Manager object.

