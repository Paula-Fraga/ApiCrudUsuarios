using Microsoft.EntityFrameworkCore;
using ApiCrudUsuarios.Data;
using ApiCrudUsuarios.Models;
using ApiCrudUsuarios.Repositories.Interfaces;

namespace ApiCrudUsuarios.Repositories
{
    public class UsuarioRepositorie : IUsuarioRepositorie
    {
        private readonly SistemaDBContex _dbContext;

        public UsuarioRepositorie(SistemaDBContex sistemaDBContex)
        {
            _dbContext = sistemaDBContex;
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} Não foi encontrado no banco de dados.");
            }
            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;
            usuarioPorId.Idade = usuario.Idade;
            usuarioPorId.Sexo = usuario.Sexo;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id} Não foi encontrado no banco de dados.");
            }
            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
