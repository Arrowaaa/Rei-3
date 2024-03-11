# REI 3 
> **Lista de exercício para testar nossas habilidades e conhecimentos, ultilizando Windows Form.** :shipit:
 
> <picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

## Objetivo :shipit:

**O projeto foi desenvolvido como _desafio_ para a turma de TI21, onde o objetivo era os seguintes:**
## Tecnologias Utilizadas:
<table>
  <tr>
    <td>PHP</td>
    <td>MySql</td>
   <td>Xamp</td>
  </tr>
  <tr>
    <td>8.2</td>
    <td>8.3</td>
   <td>8.2.12</td>
  </tr>
</table>

- [x] **Criação de Uma Agenda De Contatos**
  - [x] Função de Adicionar/Editar e Deletar Contatos salvos
  - [x] Função para salvar em txt   
- [ ] **Retorna imagem do contato**

- [x] **Crição de Um Bloco De Notas**
  - [x] Função de Adicionar/Editar e Deletar Boco de notas
  - [x] Função para salvar em txt
- [ ] **Replicar forma fiel de um bloco de notas**

- [x] **Criação de Um Gerenciador de Tarefas**
  - [x] Função de Adicionar e Atualizar e Deletar Tarefas salvas
  - [x] Conexão com banco de dados
  - [x] Função para prazos da tarefa      

- [x] **Criação de um Gerenciador de Notas**
  - [x] Função de Adicionar/Editar e Deletar, além das funções Negrito/Itálico/Sublinhado no gerenciador de notas
  - [x] Função para pesquisar e exibir a lista de notas salvas
     
- [x] **Criação de Um programa de Previsão Do Tempo**
  - [x] Função de pesquisar a cidade/estado que deseja saber a previsão
  - [x] Utilização de API
  - [x] Função para exibir imagem do clima, descrição (temperatura Máx/Min/Umidade)
- [ ] **Replicar forma fiel de um aplicativo de previsão de tempo**

- [x] **Criação de Um Relogio Mundial**
  - [x] Função para exibir horas de algums países 
  - [x] Função para ver a data/hora e local
- [ ] **Sem utilização de API**
     
- [x] **QR code**
  - [x] Função de Gerar/ Resetar e Sair do Qrcode

          
### Sub Subtitulo

   ***Ferramentas e objetivos ultilizado no projeto*** :shipit:
-  *Radio buttons*
-  *Labels*
-  *TextBoxs*
-  *ListViews*
-  *ComboBoxs*
-  *Buttons*
-  *DateTimePicker*
-  *PictureBox*

  
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
<summary>Link do API ultilizado no exercício de previsão de tempo </summary>
https://openweathermap.org/api



