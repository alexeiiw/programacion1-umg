#!/bin/bash

# Configuración de variables
LAB_NAME="lab11_crud_sqlite"
LAB_DIR="$HOME/programacion1/trabajos/$LAB_NAME"
GUIA_FILE="$LAB_DIR/README.md"

echo "🚀 Iniciando creación del entorno de laboratorio: $LAB_NAME"

# 1. Crear carpeta del laboratorio
if [ -d "$LAB_DIR" ]; then
    echo "⚠️ La carpeta ya existe. Abriendo..."
else
    mkdir -p "$LAB_DIR"
    echo "✅ Carpeta creada en: $LAB_DIR"
fi

cd "$LAB_DIR"

# 2. Inicializar proyecto de consola C# (si no existe)
if [ ! -f "Program.cs" ]; then
    dotnet new console
    echo "✅ Proyecto C# inicializado."
else
    echo "ℹ️ El proyecto C# ya estaba inicializado."
fi

# 3. Agregar paquete NuGet Microsoft.Data.Sqlite
echo "📦 Agregando paquete NuGet Microsoft.Data.Sqlite..."
dotnet add package Microsoft.Data.Sqlite
echo "✅ Paquete SQLite agregado."

# 4. Generar la Guía en Markdown (README.md)
cat <<EOF > "$GUIA_FILE"
# 📗 GUÍA 11 - CRUD CON BASES DE DATOS SQLITE

## 🎯 Objetivo
Aprender a persistir datos en una base de datos SQLite, implementando las operaciones CRUD (Create, Read, Update, Delete) para gestionar información más allá de la memoria temporal del programa.

---

## 🗄️ 1. ¿Qué es una Base de Datos?
Una **base de datos** es un sistema que almacena información de forma permanente en tablas organizadas.
- **Uso:** Sistemas de inventario, aplicaciones web, gestores de tareas.
- **SQLite:** Base de datos ligera que guarda toda la información en un solo archivo .db
- **Lógica:** Los datos se organizan en tablas (filas y columnas), similar a Excel pero más poderoso.

## 📋 2. CRUD - Las 4 Operaciones Básicas
- **Create (Crear):** Insertar nuevos registros → \`INSERT INTO Tareas ...\`
- **Read (Leer):** Consultar datos existentes → \`SELECT * FROM Tareas\`
- **Update (Actualizar):** Modificar registros → \`UPDATE Tareas SET ...\`
- **Delete (Eliminar):** Borrar registros → \`DELETE FROM Tareas WHERE ...\`

## 🔌 3. Conexión a la Base de Datos
Para conectarte a SQLite en C# necesitas:
1. **Paquete NuGet:** Microsoft.Data.Sqlite (se instala automáticamente al generar el laboratorio)
2. **Cadena de conexión:** \`"Data Source=mibase.db"\`
3. **Objeto SqliteConnection:** Abre y cierra la conexión a la BD

---

## 🚦 4. Diferencia Visual
Imagina un **Archivero de Oficina**:
- **Variables normales:** Son notas adhesivas (se pierden al apagar la PC)
- **Arreglos:** Son hojas sueltas en tu escritorio (se pierden al cerrar el programa)
- **Base de datos:** Es un archivero con cajones etiquetados (permanente, organizado, seguro)

---

## 🧭 El Reto: Sistema de Gestión de Estudiantes

Crea un programa que gestione una base de datos de estudiantes con las siguientes características:

1. **Tabla:** \`Estudiantes\` con campos:
   - Id (INTEGER PRIMARY KEY AUTOINCREMENT)
   - Nombre (TEXT)
   - Carnet (TEXT)
   - Promedio (REAL)

2. **Funcionalidades:**
   - **Agregar estudiante:** Solicitar nombre, carnet y promedio
   - **Listar estudiantes:** Mostrar todos los registros en formato tabla
   - **Actualizar promedio:** Modificar el promedio de un estudiante por su ID
   - **Eliminar estudiante:** Borrar un registro por ID
   - **Menú interactivo:** Usar do-while y switch para navegar las opciones

3. **Salida esperada:**
   - Menú con 5 opciones (4 operaciones CRUD + Salir)
   - Mensajes de confirmación para cada operación
   - Validación básica (no permitir campos vacíos)

---

## 💡 Referencia de Código
Revisa la implementación completa de CRUD con SQLite en:
\`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_crud_sqlite\`

El ejemplo usa una tabla de **Tareas (TODO List)**. Tu reto es adaptarlo para **Estudiantes**.

---

## 🚀 Instrucciones
1. Actualiza: \`git pull\`
2. Genera: \`crear-lab 11\`
3. Carpeta de trabajo: \`~/programacion1/trabajos/$LAB_NAME\`
4. El paquete SQLite ya está instalado, solo ejecuta: \`dotnet restore\`

---

## 🔑 Conceptos Clave del Ejemplo
- **using (var conexion = ...):** Asegura que la conexión se cierre automáticamente
- **SqliteCommand:** Ejecuta comandos SQL (INSERT, SELECT, UPDATE, DELETE)
- **Parameters.AddWithValue():** Previene problemas de seguridad (SQL Injection)
- **ExecuteNonQuery():** Para INSERT, UPDATE, DELETE (no retorna datos)
- **ExecuteReader():** Para SELECT (retorna filas de datos)

---

## ⚠️ Notas Importantes
- La base de datos se crea automáticamente en la carpeta del proyecto
- Usa \`INTEGER\` para números enteros y \`REAL\` para decimales en SQLite
- Siempre cierra las conexiones usando \`using\` o \`.Close()\`
- Los datos persisten entre ejecuciones del programa
EOF

echo "✅ Guía generada en $GUIA_FILE"
echo "📂 Abriendo en VS Code..."
code .
