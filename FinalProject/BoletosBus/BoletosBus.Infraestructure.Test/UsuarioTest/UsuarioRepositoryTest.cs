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

        [Fact]
        public void Get_InvalidUsuarioID_ThrowsException()
        {
            // Arrange
            int invalidUserId = 99;  // Un ID que no existe en el mock

            // Act & Assert
            var exception = Assert.Throws<KeyNotFoundException>(() => usuarioRepository.GetUsuarioById(invalidUserId));
            Assert.Equal("Usuario no encontrado", exception.Message);
        }

        [Fact]
        public void Get_usuario_ReturnUsuario()
        {
            // Arrange
            int validUserId = 1;  // Un ID válido que existe en el mock

            // Act
            var usuario = usuarioRepository.GetUsuarioById(validUserId);

            // Assert
            Assert.NotNull(usuario);
            Assert.Equal(validUserId, usuario.IdUsuario);
            Assert.Equal("usuario 1", usuario.Nombres);
        }

        [Fact]
        public void GetUsuario_WithUsuarioId_ReturnUsuario()
        {
            // Arrange
            int validUserId = 2;  // Otro ID válido que existe en el mock

            // Act
            var usuario = usuarioRepository.GetUsuarioById(validUserId);

            // Assert
            Assert.NotNull(usuario);
            Assert.Equal(validUserId, usuario.IdUsuario);
            Assert.Equal("usuario 2", usuario.Nombres);
        }


        [Fact]
        public async Task GetAllUsuarioByTipoUsuario_ReturnsUsuarios()
        {
            // Arrange
            string tipoUsuario = "Admin";

            // Act
            var usuarios = await usuarioRepository.GetAllUsuarioByTipoUsuario(tipoUsuario);

            // Assert
            Assert.NotNull(usuarios);
            Assert.IsType<List<UsuarioModel>>(usuarios);
            Assert.Single(usuarios);  // Solo hay un usuario con tipo "admin" en el mock
            Assert.Equal("usuario 1", usuarios[0].Nombres);
            Assert.Equal("Admin", usuarios[0].TipoUsuario);
        }
    }
}