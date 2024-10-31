---
marp: true
backgroundColor: 
style:
theme: gaia
size: 16:9
---

# Git x GitHub
- **Git**
Ferramenta de controle de versão que rastreia alterações e permite colaboração em projetos.


- **GitHub**
 Plataforma online que hospeda repositórios Git e fornece ferramentas adicionais para colaboração e gerenciamento de projetos.

  _para aprender um pouco mais sobre ambas as plataformas, aperte um dos botões:_   [GitHub](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA), [Git](https://www.youtube.com/playlist?list=PLucm8g_ezqNq0dOgug6paAkH0AQSJPlIe)

---

# Importância do uso de Git e GitHub
* Git
  * Controle de Versão
  * Ramificações (Branches)
  * Documentação e Histórico
* GitHub
  * Colaboração
  * Integração e Entrega Contínua (CI/CD)
  * Gerenciamento de Projetos
  * Comunidade e Recursos
---
# Alguns comandos do Git
- `code .`: Executa o arquivo ou pasta selecionada no Visual Studio Code.
- `mkdir "nome"`: Cria um novo diretório dentro da pasta.
- `cd "nome"`: utilizado para caminhar nas pastas no terminal. Seja para entrar em uma pasta ou sair da mesma.
- `ls`: comando utilizado para verificar o que há dentro do diretório selecionado.

---
- `git add "arquivo/diretório"`: Neste comando deve ser selecionado o caminho do(s) arquivo(s) ou pasta(s) a serem preparados.
- `git status`: Verifica o status do arquivo, informando se há algum commit pendente e se algum commit já foi feito.

- `git commit -m "mensagem"`: Realiza o commit e captura uma descrição do commit.
- `git log`: Verifica o histórico de mudanças no arquivo (autor, data e mensagem adicionada no commit).
- `git rm "nome"`: Exclusão do arquivo ou diretório nomeado.
---
- `git log --diff-filter=D --summary`: Cria um sumário com os commits de exclusão.


- `git checkout xxxx~1 "nome do arquivo"`: Restaura o arquivo excluído.
- `git revert xxxx`: Restaura o commit selecionado.
   - **"xxxx"** refere-se aos primeiros caracteres do commit.
   - Utilize `git log` para saber o código do commit.
- `git revert HEAD`: Restaura o último commit.

---

# Markdown
Markdown é uma linguagem de marcação leve e fácil de usar, projetada para formatar texto de forma simples e intuitiva. O Markdown permite que os usuários escrevam texto com formatação utilizando uma sintaxe simples que pode ser facilmente convertida em HTML.
 Esta apresentação, por exemplo, foi elaborada integralmente em código Markdown, utilizando a extensão Marp no Visual Studio Code e o código será disponibilizado no final da mesma.

[Clique aqui para aprender Markdown](https://www.youtube.com/watch?v=LntSB-gl-ZI)
