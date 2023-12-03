#!/bin/bash
RUTA="/var/log/secure*"
source ./funciones.sh
opcion=""
function menu(){
    clear
    echo "----------- Registro de intentos -----------"
    echo "1. Muestra intentos de login exitosos"
    echo "2. Muestra intentos de login fallidos"
    echo "3. Muestra un informe completo de intentos"
    echo "4. Salir"
    echo -e "-------------------------------------------\n"
    read -p "Elige una opción: " opcion
}

while true; do 
    menu
    clear
    echo -e "------------------------------------------------------------------------------"
    case $opcion in
    1) login_exitoso ;;
    2) login_fallidos ;;
    3) login_completo ;;
    4) exit ;;
    *) echo "Opción inválida" ;;
    esac
    echo -e "------------------------------------------------------------------------------\n\n"
    echo -e "Presione cualquier tecla para volver al menú\n"
    read
done
