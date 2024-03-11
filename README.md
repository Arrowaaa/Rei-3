# REI 3 
> **Lista de exercício para testar nossas habilidades e conhecimentos, ultilizando Windows Form.** :shipit:

![Screenshot of a comment on a GitHub issue showing an image, added in the Markdown, of an Octocat smiling and raising a tentacle.](https://myoctocat.com/assets/images/base-octocat.svg)




## Objetivo :shipit:

**O projeto foi desenvolvido como _desafio_ para a turma de TI21, onde o objetivo era os seguintes:**

- [x] **Agenda De Contatos**
  - [x] Função de Adicionar/Editar e Deletar Contatos salvos
  - [x] Função para salvar em txt   
- [ ] **Retorna imagem do contato**

- [x] **Bloco De Notas**
  - [x] Função de Adicionar/Editar e Deletar Boco de notas
  - [x] Função para salvar em txt

- [x] **Gerenciador de Tarefas**
  - [x] Função de Adicionar e Atualizar e Deletar Tarefas salvas
  - [x] Função para prazos da tarefa      

- [x] **Gerenciador de Notas**
  - [x] Função de Adicionar/Editar e Deletar, além das funções Negrito/Itálico/Sublinhado no gerenciador de notas 
  - [x] Função para pesquisar e exibir a lista de notas salvas
     
- [x] **Previsão Do Tempo**
  - [x] Função de pesquisar a cidade/estado que deseja saber a previsão
  - [x] Função para exibir imagem do clima, descrição (temperatura Máx/Min/Umidade)

- [x] **Relogio Mundial**
  - [x] Função para exibir horas de algums países 
  - [x] Função para ver a data/hora e local 
     
- [x] **QR code**
  - [x] Função de Gerar/ Resetar e Sair do Qrcode

          
### Sub Subtitulo

   ***Ferramentas e objetivos ultilizado no projeto*** :shipit:
-  *Radio buttons*
-  *Labels*

- 
` Código `
<details>
  
  <summary>Codigo de como Carregar os Arquivos salvos</summary>
  
    if (File.Exists("nomes.txt"))
    {
        string[] nomes = File.ReadAllLines("nomes.txt");
        string[] numeros = File.ReadAllLines("numeros.txt");

        for (int i = 0; i < nomes.Length; i++)
        {
            ListViewItem item = new ListViewItem(nomes[i]);
            item.SubItems.Add(numeros[i]);
            listViewContatos.Items.Add(item);
        }
    }
  
<details>
  <summary>Imagems dos Programas</summary>
 https://github.com/Arrowaaa/Rei-3/commit/d71e473e01b8268dee46424c11e7461ab172eb9a

   
<details>
<summary>Links dos APIs ultilizados no exercício de previsão de tempo </summary>
https://openweathermap.org/api



