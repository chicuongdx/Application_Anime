using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace FinalProject
{
    public partial class YoutubeSearch : Form
    {
        public YoutubeSearch()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void SearchVideo(string keyword)
        {
            try
            {
                ShowSearch(Run(keyword));
            }
            catch (AggregateException ex)
            {
                string error = "";
                foreach (var e in ex.InnerExceptions)
                {
                    error = error + "Error: " + e.Message + '\n';
                }
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<SearchResult> Run(string search)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyC4IgMQoqPKdtW7I5o4-02w1jL94Sb_7Tg",
                ApplicationName = this.GetType().ToString()
            });

            // Below is my code
            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = search;
            searchListRequest.MaxResults = 20;

            var searchListResponse = searchListRequest.Execute();

            List<SearchResult> videos = new List<SearchResult>();

            foreach (var searchResult in searchListResponse.Items)
            {
                if (searchResult.Id.Kind == "youtube#video")
                {
                    videos.Add(searchResult);
                }
            }

            return videos;
        }
        private void ShowSearch(List<SearchResult> videos)
        {
            foreach (var searchResult in videos)
            {
                YoutubeVideo video = new YoutubeVideo(searchResult);
                video.Dock = DockStyle.Top;
                pnlSearch.Controls.Add(video);
            }
        }

        /// //////////////////////////////////////////////////////////////////////////////////
        private void pctSearch_Click(object sender, EventArgs e)
        {
            SearchVideo(txtSearch.Text);
        }
    }
}
