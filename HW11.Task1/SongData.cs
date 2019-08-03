using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Task1
{
    enum Genre
    {

    }
    struct Duration
    {
        private int _minutes;
        private int _seconds;
        internal Duration(int minutes, int seconds)
        {
            _minutes = minutes;
            _seconds = seconds;
        }
        internal int Minutes
        {
            get { return _minutes; }
        }
        internal int Seconds
        {
            get { return _seconds; }
        }
        public override string ToString()
        {
            string duration = "(" + _minutes.ToString() + ":" + _seconds.ToString() + ")";
            return duration;
        }
    }
    class SongData
    {
        private readonly string _nameSong = string.Empty;
        private readonly string _authorSong = string.Empty;
        private readonly Duration _durationSong;
        private readonly int _yearOfIssueSong = 0;
        string NameSong { get; set; }
        string AuthorSong { get; set; }
        Duration Duration { get; set; }
        int YearOfIssue { get; set; }
        SongData(string nameSong, string autorSong, Duration durationSong, int yearOfIssueSong)
        {
            _nameSong = nameSong;
            _authorSong = autorSong;
            _durationSong = durationSong;
            _yearOfIssueSong = yearOfIssueSong;
        }
        dynamic GetSongData(SongData songData)
        {
            Console.WriteLine(songData.NameSong + " - " + songData.AuthorSong + songData.Duration.ToString() + "год выпуска " + songData.YearOfIssue.ToString());
            var titleSong = new
            {
                Title = songData.NameSong,
                Minute = songData.Duration.Minutes,
                AlbumYear = songData.YearOfIssue
            };
            return titleSong;
        }
        void SetSongData(out SongData songData)
        {
            Console.WriteLine("Введите название песни");
            string nameSong = Console.ReadLine();
            Console.WriteLine("Введите название автора");
            string authorSong = Console.ReadLine();
            Console.WriteLine("Введите длительность песни в формате 00:00");
            int minutes = 0;
            int seconds = 0;
            while (true)
            {
                string durationSongString = Console.ReadLine();
                string[] durationSongArray = durationSongString.Split(':');
                if (int.TryParse(durationSongArray[0], out minutes) && int.TryParse(durationSongArray[2], out seconds) && minutes < 60 && seconds < 60)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные, введите заново в формате 00:00");
                }
            }
            Duration durationSong = new Duration(minutes, seconds);
            Console.WriteLine("Введите год выпуска песни");
            int yearOfIssueSong = 0;
            while (true)
            {
                string yearOfIssueSongString = Console.ReadLine();
                if (int.TryParse(yearOfIssueSongString, out yearOfIssueSong) && yearOfIssueSong < DateTime.Now.Year)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные, введите заново в формате 00:00");
                }
            }
            songData = new SongData(nameSong, authorSong, durationSong, yearOfIssueSong);
        }
    }
    class СollectionSong
    {
        SongData[] songData;
        СollectionSong(SongData[] songDataUser)
        {
            songData = songDataUser;
        }
        void AddSongСollection()
        {
        }
        void DeleteSongCollection()
        {

        }
        void FindSongCollection()
        {

        }
    }
}
