﻿using System;
using System.Data;
using System.Data.OleDb;

namespace Table_Model.DAL
{
    public class ProdutoGateway:BaseGateway
    {
        public ProdutoGateway() { }

        public bool insereProduto(string nome, string preco, int quantidade, string genero, string edicao)
        {
            try{
            OleDbConnection cnx = GetConnection(true);
            string sql = "INSERT INTO Produto VALUES('" + preco + "'," + quantidade + ",'"+nome +"','" + genero + "','"+edicao+"')";
            OleDbCommand sqlcmd = new OleDbCommand(sql, cnx);
            sqlcmd.ExecuteNonQuery();
            return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao adicionar produto");
            }
        }

        public DataTable GetProdutos()
        {
            try{
            OleDbConnection cnx = GetConnection(true);
            DataSet ds = ExecuteQuery(cnx, "SELECT * FROM Produto");
            return ds.Tables[0];
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao fazer select de todos os produtos");
            }
        }

        public DataTable GetProdutossemid()
        {
            try{
            OleDbConnection cnx = GetConnection(true);
            DataSet ds = ExecuteQuery(cnx, "SELECT Preço,Quantidade,Nome,Genero,Ediçao FROM Produto");
            return ds.Tables[0];
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao selecionar produtos mas sem o id");
            }
        }

        public int removerProduto(int id)
        {
            try{
           string sql = " DELETE FROM Produto WHERE IdProduto="+id;
           OleDbConnection cnx = GetConnection(true);
           return ExecuteNonQuery(cnx, sql);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao remover produto");
            }
        }

        public int alterarProduto(int id, string nome, string preco, int quantidade, string genero, string edicao)
        {
            try{
            string sql = "UPDATE Produto SET Nome='"+nome+"',Preço='"+preco+"',Quantidade='"+quantidade+"',Genero='"+genero+"',Ediçao='"+edicao+"' WHERE IdProduto="+id;
            OleDbConnection cnx = GetConnection(true);
            return ExecuteNonQuery(cnx,sql);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao alterar produto");
            }
        }

        public DataTable getSugestoes(int idUser)
        {
            try
            {
                OleDbConnection cnx = GetConnection(true);
                DataSet ds = ExecuteQuery(cnx, "SELECT Produto.Genero FROM Produto, Carrinho, CarrinhoProduto where Carrinho.IdUser="+idUser+" and Carrinho.IdCarrinho = CarrinhoProduto.IdCarrinho and CarrinhoProduto.IdProduto = Produto.IdProduto group by Genero");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string genero = ds.Tables[0].Rows[0][0].ToString();
                    ds = ExecuteQuery(cnx,"Select Nome, Genero, Ediçao from Produto where Genero like '"+genero+"'");
                    return ds.Tables[0];
                }
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao selecionar sugestoes de produtos");
            }
        }
    }

    
}
