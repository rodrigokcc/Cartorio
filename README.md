# Cartorio
![image](https://github.com/user-attachments/assets/c359d331-f831-4b44-8ade-5c477d64acbb)


#Instruições para instalação

Configurar a connection string com o nome do banco criado no Postgree

![image](https://github.com/user-attachments/assets/c9d364b1-7064-4147-9d40-7df1638142b0)

Configuração Atual 
  "ConnectionStrings": {
    "DbConnection": "Host=localhost; Database=Cartorio; Username=postgres; Password=1234"


Criar banco de mesmo nome


No prompt Packdage Manager Console do Vistual Studio rodar Update-Database para criar as Tabelas, caso erro vericar connection string senhas etc

![image](https://github.com/user-attachments/assets/6ffed7e6-d713-422c-bf74-fb7913de1947)

Após comando, se tudo der certo, encontrará as tabelas criadas no banco de dados junto com a de migrations

![image](https://github.com/user-attachments/assets/07f3da0c-edf8-4e38-9483-cd9724546f86)
