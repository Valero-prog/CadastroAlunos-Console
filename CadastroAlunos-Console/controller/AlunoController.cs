using CadastroAlunos_Console.Model;

namespace CadastroAlunos_Console.Controller
{
    public class AlunoController
    {
        private List<Aluno> alunos = new();
        private int proximoId = 1;


        public void CadastrarAluno(string nome, string cpf, string curso, DateTime dataNascimento)
        {
            Aluno novoAluno = new Aluno(proximoId++, nome, cpf, dataNascimento, curso);
            alunos.Add(novoAluno);
        }

        public bool AtualizarAluno(int id, string nome, string cpf, string curso, DateTime dataNascimento)
        {
            Aluno aluno = alunos.Find(a => a.Id == id);
            if (aluno == null)
            {
                return false;
            }

            aluno.Nome = nome;
            aluno.Curso = curso;
            aluno.DataNascimento = dataNascimento;
            aluno.Cpf = cpf;
            return true;
        }

        public List<Aluno> ListarAlunos()
        {
            return alunos;
        }

        public bool ExcluirAluno(int id)
        {
            Aluno aluno = alunos.Find(a => a.Id == id);
            return aluno != null && alunos.Remove(aluno);


        }
    }
}
