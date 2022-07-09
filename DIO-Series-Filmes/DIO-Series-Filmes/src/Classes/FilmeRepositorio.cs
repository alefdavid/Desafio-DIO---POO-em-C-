using System;
using System.Collections.Generic;
using Desafio_DIO_APP_series.src.Interfaces;

namespace Desafio_DIO_APP_series
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();
        public void Atualiza(int id, Filme objeto)
        {
            listaFilme[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filme entidade)
        {
            throw new NotImplementedException();
        }

        public void InsereF(Filme objeto)
        {
            listaFilme.Add(objeto);
        }

        public void InsereFilme(Filme entidade)
        {
            throw new NotImplementedException();
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }

        Filme IRepositorio<Filme>.RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}