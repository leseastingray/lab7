#!/bin/sh

CM="CustomerMaintenance"
cd /root/lab7
xbuild ./"$CM".sln && \
mono ./CustomerTests/bin/Debug/CustomerTests.exe
