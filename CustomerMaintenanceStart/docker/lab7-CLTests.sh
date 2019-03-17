#!/bin/sh

CM="CustomerMaintenance"
cd /root/lab7
xbuild ./"$CM".sln && \
mono ./CustomerListTests/bin/Debug/CustomerListTests.exe
