# REI 3 
> **Lista de exercício para testar nossas habilidades e conhecimentos, ultilizando Windows Form.** :shipit:
 
![Rei 3](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/10761.jpg)

  

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

## Objetivo :shipit:


**O projeto foi desenvolvido como _desafio_ para a turma de TI21, onde o objetivo era os seguintes:**

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
    </details>
  
  
<details>
<summary>Link do API ultilizado no exercício de previsão de tempo </summary>
https://openweathermap.org/api
</details>

<details>
  <summary>Print da tela do Windows Form dos Programas</summary>

![Agenda de Contato](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/Agenda%20de%20Contato.PNG)

![Bloco de notas](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/Bloco%20de%20notas.PNG)

![Gerenciador de notas](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/Gerenciador%20de%20notas.PNG)

![Gerenciador de notas](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/Gerenciador-de-notas.PNG)

![Gerenciador de tarefas](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/Gerenciador%20de%20tarefas.PNG)

![Previsão do tempo](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/Previs%C3%A3o%20do%20tempo.PNG)

![Relógio mundial](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/relogio%20mundial.PNG)

![QRCode](https://raw.githubusercontent.com/Arrowaaa/Rei-3/main/Qrcode.PNG)

</details>






