ftp -v ftp://ericminio-001:Yose12345@ftp.mywindowshosting.com <<-ENDTAG
binary
prompt
cd site1

mdelete views/home/*
mdelete views/*
rmdir views
mdelete bin/*
rmdir bin
mdelete *

lcd YoseTheGame

put Web.config
put Global.asax

mkdir bin
lcd bin
cd bin
mput *.dll
lcd ..
cd ..

mkdir views
lcd views
cd views
put Web.config
mkdir Home
lcd Home
cd Home
put Home.cshtml
lcd ..
cd ..

ls
ls views
ls bin

ENDTAG