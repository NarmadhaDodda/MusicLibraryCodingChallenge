using System;
using System.Collections.Generic;
using Xunit;

public class MusicLibraryTests
{
    [Fact]
    public void GetMusicTracks_ReturnsAtLeastOneTrack()
    {
        // Arrange
        var musicLibrary = new MusicLibrary(new List<MusicLibrary.Track>
        {
            new MusicLibrary.Track { Artist = "Artist1", Title = "Song1", Genre = "Rock", Duration = 180 },
           
        });

        // Act
        var result = musicLibrary.GetMusicTracks("Rock");

        // Assert
        Assert.NotEmpty(result);
    }

    [Fact]
    public void GetMusicTracks_ReturnsTracksWithMatchingGenre()
    {
        // Arrange
        var musicLibrary = new MusicLibrary(new List<MusicLibrary.Track>
        {
            new MusicLibrary.Track { Artist = "Artist1", Title = "Song1", Genre = "Rock", Duration = 180 },
            new MusicLibrary.Track { Artist = "Artist2", Title = "Song2", Genre = "Pop", Duration = 210 },
            
        });

        // Act
        var result = musicLibrary.GetMusicTracks("Rock");

        // Assert
        Assert.All(result, track => Assert.Equal("Rock", track.Genre));
    }

    [Fact]
    public void GetMusicTracks_ReturnsNoTracksWithZeroDuration()
    {
        // Arrange
        var musicLibrary = new MusicLibrary(new List<MusicLibrary.Track>
        {
            new MusicLibrary.Track { Artist = "Artist1", Title = "Song1", Genre = "Rock", Duration = 0 },
            new MusicLibrary.Track { Artist = "Artist2", Title = "Song2", Genre = "Pop", Duration = 210 },
            
        });

        // Act
        var result = musicLibrary.GetMusicTracks("Rock");

        // Assert
        Assert.DoesNotContain(result, track => track.Duration == 0);
    }
}
