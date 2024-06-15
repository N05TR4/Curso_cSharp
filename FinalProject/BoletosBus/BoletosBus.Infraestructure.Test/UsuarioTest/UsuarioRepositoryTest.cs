using BoletosBus.Domain.Entities;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Domain.Models;
using BoletosBus.Infraestructure.Repositories.Mock;




namespace BoletosBus.Infraestructure.Test
{
    public class UsuarioRepositoryTest
    {
        
        private IUsuarioRepository usuarioRepository;


        public UsuarioRepositoryTest()
        {
            usuarioRepository = new UsuarioMockRepository();

        }



        [Fact]
        public void GetAllUsuario_WithValidUsuarioModel()
        {
            //Arrange
            var usuario = this.usuarioRepository.GetAllUsuario();



            

            //Assert
            Assert.NotNull(usuario);
            Assert.IsType<List<UsuarioModel>>(usuario);
            Assert.NotEmpty(usuario);

            //Expect
            var expectedUserName = "usuario 1";


            // Assert adicional para el primer usuario
            Assert.Equal(expectedUserName, usuario[0].Nombres);



        }
    }
}