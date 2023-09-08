using System;
using System.Collections.Generic;
using System.Linq;

public class MusicLibrary
{
    // Sample Track class representing a music track.
    public class Track
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; } // Duration in seconds
    }

    // Sample list of music tracks
    private List<Track> allTracks;

    public MusicLibrary(List<Track> tracks)
    {
        allTracks = tracks;
    }

    public List<Track> GetMusicTracks(string genre)
    {
        // Filters tracks by the specified genre and validate for non-zero duration.
        return allTracks
            .Where(track => track.Genre == genre && track.Duration > 0)
            .OrderBy(track => track.Artist)
            .ThenBy(track => track.Title)
            .ToList();
    }
}
