using System.Net.Http.Json;

namespace Puzzle_48.Client;

public record Episode(int Number, DateOnly PublishDate, string Title);

public interface IEpisodeClient
{
	Task<Episode[]> GetEpisodes();
	Task<Episode> GetEpisode(int id);
}

public class EpisodeClient : IEpisodeClient
{
	private readonly HttpClient _httpClient;
	public EpisodeClient(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}
	public async Task<Episode[]> GetEpisodes()
	{
		return await _httpClient.GetFromJsonAsync<Episode[]>("/api/episodes");
	}
	public async Task<Episode> GetEpisode(int id)
	{
		return await _httpClient.GetFromJsonAsync<Episode>($"/api/episodes/{id}");
	}
}