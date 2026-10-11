using ExercicioPOO3_Usuario;

Usuario usuario = new Usuario("ana123", "segredo");

Console.WriteLine(usuario.ConferirSenha("1234"));
Console.WriteLine(usuario.ConferirSenha("segredo"));

usuario.TrocarSenha("errada", "novaSenha");
usuario.TrocarSenha("segredo", "novaSenha");

Console.WriteLine(usuario.ConferirSenha("novaSenha"));


