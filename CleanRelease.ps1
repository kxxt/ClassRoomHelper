del ClassRoomHelper\bin\Release\*.pdb
del ClassRoomHelper\bin\Release\*.xml
del -Force ClassRoomHelper\bin\Release\Files\*
del -Force ClassRoomHelper\bin\Release\Logs\*
mv -Force -Path ClassRoomHelper\bin\Release\*.dll -Destination ClassRoomHelper\bin\Release\bin\
mv -Force -Path ClassRoomHelper\bin\Release\*.dll.config -Destination ClassRoomHelper\bin\Release\bin\
mv -Force -Recurse -Path ClassRoomHelper\bin\Release\zh-CN -Destination ClassRoomHelper\bin\Release\bin\
New-Item ClassRoomHelper\bin\Release\FirstRun -type file -force