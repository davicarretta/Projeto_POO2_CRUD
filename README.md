Este é um projeto para a disciplina de Programação Orientada a Objetos II, turma CC4M 2024/2, coordenada pelo professor Wagner de Andrade Perin, pela Universidade Vila Velha (UVV), criado e desenvolvido por mim (Davi Carretta Barcellos).

Esse projeto foi desenvolvido em C# e tem como objetivo consolidar nossa compreensão da integração com bancos de dados usando C# e aplicações Windows Forms, além da capacidade de colocar em prática de padrões de projeto, especificamente o padrão Singleton para gerenciamento da conexão com o banco de dados e incluindo operações de CRUD básicas.

Para este projeto, escolhi um modelo de dados de Sistema de Estoque (mais especificamente de uma lanchonete), que consiste no controle de estoque de salgados, doces, refrigerantes, etc, além do controle de fornecedores disponíveis.

Para usar e testar esse projeto, baixe o ZIP do arquivo e abra a pasta do projeto no seu Visual Studio. Em seguida, você precisará instalar o pacote MySQL.Data, para manuseamento e utilização de uma interface integrada com banco de dados MariaDB. Utilize o código SQL disponibilizado nesse site para criar seu banco de dados com tabelas, colunas e inserções de exemplo (que já estão definidas no script do BD).

Depois disso, defina sua conexão com o banco de dados na classe DatabaseConnection.cs, e inicialize o aplicativo. O mesmo contém 3 tabelas com operações CRUD, onde você pode fazer inserções de dados, pesquisas, remoções e atualizações dos dados das colunas das tabelas. Para inserir novos dados, preencha os campos disponíveis e clique no botão de adicionar. Para remover uma linha, selecione ela na tabela e clique em excluir. Para pesquisar dados na tabela, insira os dados que desejar nos seus respectivos campos e clique em pesquisar. E por último, para atualizar, insira os dados que deseja atualizar nos seus respectivos campos e clique em atualizar. 

ATENÇÃO: A tabela Pedidos é dependente de colunas de outras tabelas. Certifique-se de usar dados válidos nas outras tabelas para modificar essa. O botão ao lado do campo da Data do Pedido serve para você especificar se quer ou não usar a data como quesito quando for pesquisar por dados específicos. Adicionei essa funcionalidade pois esse elemento de seleção de data não permite selecionar uma data nula. Se você quiser levar em conta a data, clique na caixa, caso contrário, não clique. Dessa forma, sua pesquisa funcionará corretamente.

Em caso de dúvidas, entre em contato pelo E-Mail: dacabax@gmail.com

Obrigado!
