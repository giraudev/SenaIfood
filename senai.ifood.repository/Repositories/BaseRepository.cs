using System; 
using System.Collections.Generic; 
using System.Linq; 
using Microsoft.EntityFrameworkCore; 
using senai.ifood.domain.Contacts; 
using senai.ifood.repository.Context; 

namespace senai.ifood.repository.Repositories {
	public class BaseRepository < T > :IBaseRepository < T > where T:class {
		
		#region Context
		private readonly IFoodContext _dbContext; 
		public BaseRepository (IFoodContext ifoodcontext) {
			_dbContext = ifoodcontext; 
		}
		#endregion

		#region Método Atualizar
		public int Atualizar (T dados) {
			try {
				_dbContext.Set < T > ().Update (dados); 
				return _dbContext.SaveChanges (); 

			}catch (System.Exception ex) {
				throw new Exception (ex.Message); 
			}
		}
		#endregion

		#region Método BuscarPorId
		public T BuscarPorId (int id) {
			try {
				/*No generics ele não sabe oq é Id, por isso temos que identificar a chave
				primária. */
				var chavePrimaria = _dbContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties[0]; 
				return _dbContext.Set < T > ().FirstOrDefault(e => EF.Property < int > (e, chavePrimaria.Name) == id); 
			}
			catch (System.Exception ex) {
				throw new Exception (ex.Message); }
		}
		#endregion
		
		#region Método Deletar
		public int Deletar (T dados) {
			try {
				_dbContext.Set < T > ().Remove (dados); 
				return _dbContext.SaveChanges (); 
			}catch (System.Exception ex) {
				throw new Exception (ex.Message); 
			}
		}
		#endregion

		#region Método Inserir
		public int Inserir (T dados) {

			try {
				_dbContext.Set < T > ().Add (dados); 
				return _dbContext.SaveChanges(); 

			}catch (System.Exception ex) {
				throw new Exception (ex.Message); 
			}
		}
		#endregion

		#region Método Listar

		public IEnumerable < T > Listar () {
			 try {
return _dbContext.Set < T > ().ToList(); 
}
catch (System.Exception ex) {
throw new Exception (ex.Message); 
}

			#endregion
	}
}}
