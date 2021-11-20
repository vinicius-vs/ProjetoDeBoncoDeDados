# ProjetoDeBancoDeDados
Esse projeto foi desenvolvido utilizando a liguagem C#,Windows Forms e um banco de dado sql serve, para a comunicação com o baco de dados foi utilizado o EntityFramework versão 6.4.4.


Para executar recomendamos subir um condeiner sql server no docker utilisando o comando:docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=74269" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-CU13-ubuntu-20.04, ou se preferir pode-se intalar o sql server direto na maquina.

Logo em seguida precisara conectar o banco de dados no IDE, para cada ide utilizado ira mudar a forma de se conectar,  recomendamos usar o visual studio para executar esse projeto; 

para conectar o programa ao banco sera necessario trocar a string conect no arquivo resConText.cs na pasta Context no projeto Data;

apois isso precisara da um update no banco, caso se voçê esteja esecutando no visual studio, basta abrir o Console de pacotes nuget e dar o comando: UPDATE-DATABASE 

Pronto agora apenas falta executar o projeto Condominios_Sol_Nascente.
