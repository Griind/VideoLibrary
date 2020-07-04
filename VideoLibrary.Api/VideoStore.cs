using System.Collections.Generic;
using VideoLibrary.Api.Models;

namespace VideoLibrary.Api
{
    public class VideoStore
    {
        private readonly List<Video> _videos;

        public VideoStore()
        {
            _videos = new List<Video>();
        }

        public IEnumerable<Video> All => _videos;

        public void Add(Video video)
        {
            video.Id = _videos.Count + 1;
            _videos.Add(video);
        }
    }
}