using System;
using System.Data;
using CCAT16.Conta.Dominio;
using Dapper;
using Dominio = CCAT16.Conta.Dominio;

namespace CCAT16.Data.Repositorios.Conta
{
    public class ContaRepositorio : IContaRepositorio
    {
        private CCAT16Context _Contexto;

        public ContaRepositorio(CCAT16Context contexto)
        {
            _Contexto = contexto;
        }

        public Dominio.Conta ObterPorId(int id)
        {
            string select = @"SELECT
                                account_id,
                                name,
                                email,
                                cpf,
                                car_plate,
                                is_passenger,
                                is_driver
                            FROM 
                                cccat16.account
                            WHERE
                                account_id = @id";

            var parametro = new DynamicParameters();
            parametro.Add("@id", id);

            throw new NotImplementedException();
        }

        public int Salvar(Dominio.Conta conta)
        {
            string insert = @"INSERT INTO cccat16.account 
                            (
	                            name,
                                email,
	                            cpf,
	                            car_plate,
	                            is_passenger,
	                            is_driver
                            )
                            VALUES
                            (
	                            @nome,
                                @email,
	                            @cpf,
	                            @placa,
	                            @passageiro,
	                            @motorista
                            )";

            var parametros = new DynamicParameters();
            parametros.Add("@nome", conta.Nome);
            parametros.Add("@email", conta.Email.Endereco);
            parametros.Add("@cpf", conta.Cpf);
            parametros.Add("@placa", conta.PlacaDoCarro.Numeracao);
            parametros.Add("@passageiro", conta.EhPassageiro);
            parametros.Add("@motorista", conta.EhMotorista);

            var id = _Contexto.Conexao.Execute(insert, commandType: CommandType.Text, param: parametros);
            return id;
        }
    }
}
