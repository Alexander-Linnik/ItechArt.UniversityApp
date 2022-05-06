namespace ITechArt.UniversityApp.Core.Entities.Abstracts
{
	public interface IIdentifiable : IEntityMarker
	{
		long Id { get; set; }
	}
}
