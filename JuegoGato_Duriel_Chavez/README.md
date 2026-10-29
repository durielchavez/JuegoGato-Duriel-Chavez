# Juego de gato (X/O) — Duriel Chavez

## Descripción
Juego de gato o tres en raya desarrollado en C# para consola. Participan dos jugadores: X y O. Cada jugador elige una casilla del 1 al 9 por turno. Gana quien consiga tres símbolos iguales en línea horizontal, vertical o diagonal. Si se llenan todas las casillas sin ganador, hay empate.

## Autor
**Estudiante:** Duriel Chavez

## Requisitos
- .NET 8 SDK o una versión compatible.
- Git para llevar el control de versiones.
- Una cuenta de GitHub para publicar el repositorio.

## Cómo ejecutar el juego
Desde la carpeta del proyecto, abre una terminal y ejecuta:

```bash
dotnet run
```

## Funcionalidades
- Tablero de nueve casillas.
- Turnos alternados entre X y O.
- Validación de entradas.
- Impide seleccionar casillas ocupadas.
- Detección de victoria horizontal, vertical y diagonal.
- Detección de empate.
- Opción para volver a jugar.

## Publicar el proyecto en GitHub

1. Entra en https://github.com y crea un repositorio nuevo llamado `JuegoGato-Duriel-Chavez`.
2. No es necesario agregar README, `.gitignore` ni licencia desde GitHub, porque este proyecto ya contiene un README y un `.gitignore`.
3. Abre la terminal dentro de esta carpeta y ejecuta:

```bash
git init
git add .
git commit -m "Crear juego de gato en C#"
git branch -M main
git remote add origin https://github.com/TU-USUARIO/JuegoGato-Duriel-Chavez.git
git push -u origin main
```

4. Sustituye `TU-USUARIO` por tu nombre de usuario real de GitHub antes de ejecutar el comando `git remote add origin`.
5. Actualiza la página del repositorio y comprueba que aparezcan `Program.cs`, `JuegoGato.csproj` y este README.

## Ejemplo de trabajo con una rama
Para documentar una mejora, por ejemplo, agregar un mensaje de bienvenida:

```bash
git checkout -b mejora/mensaje-bienvenida
# Realiza y guarda los cambios en el código
git add .
git commit -m "Mejorar mensaje de bienvenida"
git push -u origin mejora/mensaje-bienvenida
```

Luego, en GitHub, abre un **Pull request** desde `mejora/mensaje-bienvenida` hacia `main`, revisa los cambios y selecciona **Merge pull request** cuando corresponda.

## Nota académica
El repositorio sirve como evidencia de publicación del código. Para demostrar colaboración con GitHub, los commits, la rama y el pull request deben realizarse realmente en la cuenta del estudiante. No se debe afirmar que un pull request fue aprobado si todavía no se ha realizado.
