using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using Google.Apis.YouTube.v3.Data;
using System.Net;
using System.Drawing;

namespace FinalProject
{
    public partial class YoutubeVideo : UserControl
    {
        public string URL;
        public YoutubeVideo(SearchResult searchResult)
        {
            InitializeComponent();
            string title = searchResult.Snippet.Title;
            string author = searchResult.Snippet.ChannelTitle;
            string url = "";
            byte[] imageBytes = new WebClient().DownloadData(searchResult.Snippet.Thumbnails.Default__.Url);

            Image thumbnail;
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                thumbnail = Image.FromStream(ms);
            }
            URL = url;
            Title.Text = title;
            Author.Text = author;
            Thumbnail.Image = cv2.resize_width(thumbnail, Thumbnail.Width);
        }
    }
}
