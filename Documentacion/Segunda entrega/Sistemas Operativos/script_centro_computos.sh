#!/bin/bash

#Script de centro de computos
#Zennet
#Version 1.0

GREEN='\033[0;32m'
YELLOW='\033[1;33m'
NC='\033[0m'


echo -e "${GREEN}---- Información del Sistema ----${NC}"
echo -e "${YELLOW}Hostname:${NC} $(hostname)"
echo -e "${YELLOW}Sistema Operativo:${NC} $(cat /etc/os-release | grep "PRETTY_NAME" | cut -d'"' -f 2)"
echo -e "${YELLOW}Kernel:${NC} $(uname -r)"
echo -e "${YELLOW}Memoria Total:${NC} $(free -m | awk 'NR==2 {print $2 " MB"}')"
echo -e "${YELLOW}CPU:${NC} $(lscpu | grep "Model name" | cut -d':' -f 2 | sed 's/^ *//')"
echo -e "${GREEN}--------------------------------${NC}"
echo -e " "
echo -e " "
echo -e "${GREEN}---- Uso de CPU y Memoria ----${NC}"
echo -e "${YELLOW}Uso de CPU:${NC} $(top -b -n 1 | grep "Cpu(s)" | awk '{print $2 "%"}')"
echo -e "${YELLOW}Memoria Usada:${NC} $(free -m | grep "Mem:" | awk '{print $3 " MB"}') / ${YELLOW}Memoria Total:${NC} $(free -m | grep "Mem:" | awk '{print $2 " MB"}')"
echo -e "${GREEN}--------------------------------${NC}"
echo -e " "
echo -e " "
echo -e "${GREEN}---- Informacion Relevante ----${NC}"
echo -e "${YELLOW}Usuarios Conectados:${NC}"
who
echo -e "${YELLOW}Espacio en Disco:${NC}"
df -h
echo -e "${GREEN}--------------------------------${NC}"
echo -e " "
echo -e " "
echo -e "${GREEN}¡Script de Operador de Centro de Cómputos finalizado!${NC}"
