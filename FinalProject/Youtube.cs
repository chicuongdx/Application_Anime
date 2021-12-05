using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;

namespace FinalProject
{
    public partial class Youtube : Form
    {
        public Youtube()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<YoutubeVideo> list = new List<YoutubeVideo>();
            //Search video with paging
            List<VideoInformation> listVideo = items.SearchQuery(txtSearch.Text, 1);
            foreach (var item in listVideo)
            {
                YoutubeVideo video = new YoutubeVideo();
                video.Title = item.Title;
                video.Author = item.Author;
                video.Url = item.Url;
                //Get thumbnail
                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    video.Thumbnail = Image.FromStream(ms);
                }
                list.Add(video);
            }
            //Add videos to datagridview
            youtubeVideoBindingSource.DataSource = list;
        }
    }
}
