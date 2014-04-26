this tool is for reseting usb port on a rasbperry pi

to compile it just run

gcc usbreset.c -o usbreset

to reset desired port run

usbreset /dev/bus/usb/001/005

where 001/005 is a port id
port id can be read by running
gphoto2 --auto-detect
and from there just read a port you want to
reset








