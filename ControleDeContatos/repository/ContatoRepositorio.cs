using ControleDeContatos.Data;
using ControleDeContatos.Models;

namespace ControleDeContatos.repository
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext) {

            _bancoContext = bancoContext;


        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravar no banco de dados;

            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }


    }
}
