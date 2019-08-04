using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Task1
{
    enum GenreMusic
    {
        None = 0,
        Ambient = 1,
        Blues = 2,
        Chanson = 3,
        Club = 4,
        Country = 5,
        Dance = 6,
        Disco = 7,
        Folk = 8,
        Funk = 9,
        HipHop = 10,
        House = 11,
        Jazz = 12,
        Metal = 13,
        Pop = 14,
        Punk = 15,
        Rap = 16,
        Reggae = 17,
        Retro = 18,
        RAndB = 19,
        Rock =  20,
        Soul = 21,
        Techno = 22,
        Trance = 23
    }
    struct Duration
    {
        private readonly int _minutes;
        private readonly int _seconds;
        internal Duration(int minutes, int seconds)
        {
            _minutes = minutes;
            _seconds = seconds;
        }
        internal int Minutes { get { return _minutes; } }
        internal int Seconds { get { return _seconds; } }
        public override string ToString()
        {
            string duration = string.Format(_minutes.ToString("D2") + ":" + _seconds.ToString("D2"));
            return duration;
        }
    }
    class SongData
    {
        private readonly string _nameSong = string.Empty;
        private readonly string _authorSong = string.Empty;
        private readonly Duration _durationSong;
        private readonly int _yearOfIssueSong = 0;
        private readonly GenreMusic _genreMusic = 0;
        string NameSong { get { return _nameSong; } }
        string AuthorSong { get { return _authorSong; } }
        Duration Duration { get { return _durationSong; } }
        int YearOfIssue { get { return _yearOfIssueSong; } }
        GenreMusic GenreMusic { get { return _genreMusic; } }
        SongData(string nameSong, string autorSong, Duration durationSong, int yearOfIssueSong, GenreMusic genreMusic)
        {
            _nameSong = nameSong;
            _authorSong = autorSong;
            _durationSong = durationSong;
            _yearOfIssueSong = yearOfIssueSong;
            _genreMusic = genreMusic;
        }
        internal static dynamic GetSongData(SongData songData)
        {
            Console.WriteLine("Информация о песне\n{0} - {1}, длительность - {2}, год выпуска {3}, жанр: {4}", songData.NameSong, songData.AuthorSong, songData.Duration.ToString(), songData.YearOfIssue.ToString(), songData.GenreMusic);
            var titleSong = new
            {
                Title = songData.NameSong,
                Minute = songData.Duration.Minutes,
                AlbumYear = songData.YearOfIssue
            };
            return titleSong;
        }
        internal static void SetSongData(out SongData songData)
        {
            Console.WriteLine("Введите название песни");
            string nameSong = Console.ReadLine();
            Console.WriteLine("Введите исполнителя песни");
            string authorSong = Console.ReadLine();
            Console.WriteLine("Введите длительность песни в формате 00:00");
            int minutes = 0;
            int seconds = 0;
            while (true)
            {
                string durationSongString = Console.ReadLine();
                string[] durationSongArray = durationSongString.Split(':');
                if (durationSongArray.Length==2)
                {
                    if (int.TryParse(durationSongArray[0], out minutes) && int.TryParse(durationSongArray[1], out seconds) && minutes < 60 && seconds < 60)
                    {
                        break;
                    }
                }
                Console.WriteLine("Неверно введены данные, введите заново в формате 00:00");
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
                    Console.WriteLine("Неверно введены данные, введите год выпуска песни");
                }
            }
            Console.WriteLine("Введите № жанра соответствующий песне");
            for (int i = 0; i < 24; i++)
            {
                Console.WriteLine((GenreMusic)i + "-" + i.ToString());
            }
            GenreMusic genreMusic;
            int genreMusicInt = 0;
            while (true)
            {
                string genreMusicString = Console.ReadLine();
                if (int.TryParse(genreMusicString, out genreMusicInt) && genreMusicInt < 24)
                {
                    genreMusic = (GenreMusic)genreMusicInt;
                    break;
                }
                else
                {
                    Console.WriteLine("Неверно введены данные, введите заново число");
                }
            }
            songData = new SongData(nameSong, authorSong, durationSong, yearOfIssueSong, genreMusic);
        }
    }
}
