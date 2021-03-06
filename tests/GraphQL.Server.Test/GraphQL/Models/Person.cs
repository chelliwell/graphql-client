using System;
using System.Linq;
using GraphQL.Types;

namespace GraphQL.Server.Test.GraphQL.Models {

	public class Person {
		public string BirthYear { get; set; }
		public DateTime Created { get; set; }
		public DateTime Edited { get; set; }
		public string EyeColor { get; set; }
		public IQueryable<Film> Films { get; set; }
		public string Gender { get; set; }
		public string HairColor { get; set; }
		public string Height { get; set; }
		public Planet Homeworld { get; set; }
		public int Id { get; set; }
		public string Mass { get; set; }
		public string Name { get; set; }
		public string SkinColor { get; set; }
		public IQueryable<Specie> Species { get; set; }
		public IQueryable<Starship> Starships { get; set; }
		public IQueryable<Vehicle> Vehicles { get; set; }
	}

	public class PersonGraphType : ObjectGraphType<Person> {

		public PersonGraphType() {
			this.Name = nameof(Person);
			this.Field(expression => expression.BirthYear);
			this.Field(expression => expression.Created);
			this.Field(expression => expression.Edited);
			this.Field(expression => expression.EyeColor);
			this.Field<ListGraphType<FilmGraphType>>("films");
			this.Field(expression => expression.Gender);
			this.Field(expression => expression.HairColor);
			this.Field(expression => expression.Height);
			this.Field<PlanetGraphType>("homeworld");
			this.Field(expression => expression.Id);
			this.Field(expression => expression.Mass);
			this.Field(expression => expression.Name);
			this.Field(expression => expression.SkinColor);
			this.Field<ListGraphType<SpecieGraphType>>("species");
			this.Field<ListGraphType<StarshipGraphType>>("starships");
			this.Field<ListGraphType<VehicleGraphType>>("vehicles");
		}

	}

}
