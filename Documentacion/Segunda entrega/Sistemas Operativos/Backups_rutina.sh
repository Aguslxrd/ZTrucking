#!/bin/bash

#Script de Rutina ligada a backup
#Zennet
#Version 1.0

GREEN='\033[0;32m'
YELLOW='\033[1;33m'
NC='\033[0m'

hora=$(date +'%H:%M:%S')

echo -e "${YELLOW} ------  Bienvenido al servicio de rutinas diarias. ----- ${NC}"
echo -e " "
echo -e  "${GREEN} Se procede a la ejeccucion de respaldo de archivos sensibles... ${NC}"

playbooks_dir="$HOME/etc/ansible/hosts"

backup_dir="$HOME/Escritorio/backups/ansible_playbooks"

echo -e "${YELLOW} ------  Hora de realizado el respaldo ----- ${NC}"
echo -e "${YELLOW} "$hora" ${NC}"
echo -e " "
echo -e " "
echo -e "${GREEN} Creando directorio para backups... ${NC}"

mkdir -p "$backup_dir"

echo -e "${GREEN} Comprimiendo... ${NC}"
echo -e " "
zip -r "$playbooks_dir" "$backup_dir"

echo -e "${GREEN} Backup rutinario ejecutado correctamente ${NC}"
echo -e " "
echo -e "${GREEN} Archivos de respaldo almacenados en: "$backup_dir" ${NC}"
