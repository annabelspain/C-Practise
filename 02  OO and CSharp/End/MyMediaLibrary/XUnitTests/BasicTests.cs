using MyMediaLibrary.Model;
using System;
using Xunit;

namespace XUnitTests
{
    public class BasicTests
    {
        [Fact]
        public void Add_1_MediaItem_OK()
        {
            MediaLibrary mediaLibrary = new MediaLibrary();  
            MediaItem mediaItem = new MediaItem();
            mediaItem.Title = "Jaws";

            mediaLibrary.Add(mediaItem);

            Assert.True(mediaLibrary.GetMediaItemCount() == 1);
        }
    }
}
