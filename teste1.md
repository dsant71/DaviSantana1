# Comandos do Git

No momento, estou fazendo o curso de Git com [Bóson](https://www.youtube.com/playlist?list=PLucm8g_ezqNq0dOgug6paAkH0AQSJPlIe) e resolvi criar esse texto utilizando markdown para fazer anotações acerca do curso.

- `code .`: Executa o arquivo ou pasta selecionada no Visual Studio Code.
- `mkdir "nome"`: Cria um novo diretório dentro da pasta.

- `cd "nome"`: : utilizado para caminhar nas pastas no terminal. Seja para entrar em uma pasta ou sair da mesma.
- `ls`: comando utilizado para verificar o que há dentro do diretório selecionado.

- `git add "arquivo/diretório"`: Neste comando deve ser selecionada o caminho do(s) arquivo(s) ou pasta(s) a serem preparados.
git status: Verifica o status do repositório.
- `git status`: Verifica o status do arquivo, informando se há algum commit pendente e se algum commit já foi feito.
- `git commit -m "mensagem"`: Realiza o commit e captura uma descrição do commit.
- `git log`: Verifica o histórico de mudanças no arquivo (autor, data e mensagem adicionada no commit).
- `git rm "nome"`: Exclusão do arquivo ou diretório nomeado.
- `git log --diff-filter=D --summary`: Cria um sumário com os commits de exclusão.
- `git checkout xxxx~1 "nome do arquivo"`: Restaura o arquivo excluído.
- `git revert xxxx`: Restaura o commit selecionado.
   - **"xxxx"** refere-se aos primeiros caracteres do commit.
   - Utilize `git log` para saber o código do commit.
- `git revert HEAD`: Restaura o último commit.
