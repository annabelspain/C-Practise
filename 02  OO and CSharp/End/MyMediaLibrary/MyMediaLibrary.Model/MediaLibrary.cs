using System;
using System.Collections.Generic;
using System.Text;

namespace MyMediaLibrary.Model
{
    public class MediaLibrary
    {
        List<MediaItem> mediaItems = new List<MediaItem>();

        public void Add(MediaItem mediaItem)
        {
            mediaItems.Add(mediaItem);
        }

        public int GetMediaItemCount()
        {
            return mediaItems.Count;
        }
    }
}
