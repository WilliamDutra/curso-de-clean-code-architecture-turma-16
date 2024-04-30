using System;

namespace CCAT16.Conta.Dominio
{
    public interface IContaRepositorio
    {
        int Salvar(Conta conta);

        Conta ObterPorId(int id);
    }
}
