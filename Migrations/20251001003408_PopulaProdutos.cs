﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "values('Coca-Cola Diet','Refrigerante de cola 350 ml',5.45,'cocacola.jpg',50,now(), 1)");
            migrationBuilder.Sql(
                "Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "values('Lanche de Atum','Lanchde de Atum com maionese',8.50,'atum.jpg',10,now(), 2)");
            migrationBuilder.Sql(
                "Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                "values('Pudim 10g','Pudim de leite condensado 100g',6.75,'pudim.jpg',20,now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}
