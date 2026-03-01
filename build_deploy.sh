zipname=ExpandedFoods_net10.zip

dotnet build && pushd EFRecipes/bin/Debug/Mods/mod/net10.0/ && rm -f $zipname && zip -r $zipname * && cp $zipname ~/vsmod-packages/ && cp ~/vsmod-packages/$zipname ~/.config/VintagestoryData/Mods/ && popd
