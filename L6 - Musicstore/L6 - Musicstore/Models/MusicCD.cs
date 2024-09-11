using System.Globalization;

namespace L6___Musicstore.Models;

public class MusicCD : Product
{
    public string Artist { get; set; }
    public string Label { get; set; }
    public short Released { get; set; }
    public List<string> Tracks { get; set; }

    public List<Track> TrackList { get; set; }

    public TimeSpan GetPlayingTime()
    {
        TimeSpan timeSpan = TimeSpan.Zero;
        foreach (Track track in TrackList)
        {
            TimeSpan trackTS = TimeSpan.ParseExact(track.Length, @"m\:ss", CultureInfo.InvariantCulture);
            timeSpan = timeSpan.Add(trackTS);
        }

        return timeSpan;
    }


    public MusicCD() : base()
    {

    }

    public MusicCD(string title, double price, string artist, string label, short released) : base(title, price)
    {
        Artist = artist;
        Label = label;
        Released = released;
        Tracks = [];
    }

    public MusicCD(string title, double price, string artist, string label, short released, List<string> tracks) : base(title, price)
    {
        Artist = artist;
        Label = label;
        Released = released;
        Tracks = tracks;
    }

    public MusicCD(string title, double price, string artist, string label, short released, List<Track> tracks) : base(title, price)
    {
        Artist = artist;
        Label = label;
        Released = released;
        TrackList = tracks;
    }

    public void AddTrack(string track)
    {
        Tracks.Add(track);
    }

    public void AddTrack(Track track)
    {
        TrackList.Add(track);
    }
}
