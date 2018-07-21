using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Globalization;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Web.Services.Protocols;
using System.Xml;
using System.Diagnostics;
using System.Threading;

namespace Gamechanger
{

    public partial class GameChanger : Form
    {
     
        public Label ltime;
 
        public Object[] games;
        public Object[] appid;
        public int totaltime;
        public int seconds;
        public int currenttime;
        public GameChanger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

            string url = "https://newsapi.org/v2/top-headlines?sources=ign&apiKey=fc9c3e159a864c52ba1b1725c263f84f";

            var webclient = new WebClient();


            var json = webclient.DownloadString(url);



            ign userinfo = JsonConvert.DeserializeObject<ign>(json);


            //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ign));

            txtign.Text = "";


            for (int i = 0; i < userinfo.totalResults; i++)
            {
                txtign.Text += "Title:       " + userinfo.articles[i].title.ToString() + "\r\n\r\n" + "Description:       " + userinfo.articles[i].description.ToString() + "\r\n\r\n" + "URL:       " + userinfo.articles[i].url.ToString() + "\r\n" + "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\r\n\r\n";



            }




            txttime.Text = Convert.ToString("1");


          





            /*  for (int i = 0; i < userinfo.totalResults; i++)
              {

                  userinfo..ToString();


                  Console.WriteLine(userinfo.articles);
              }
            */

            // webBrowser1.Navigate( "http://www.ign.com/articles");

            ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();


            


           sc.ClientCredentials.UserName.UserName = "Szarath";
            sc.ClientCredentials.UserName.Password = "Szarath115";
            sc.Open();


            //   games = sc.Getgames();


            // sc1.Open();

            //ServiceReference2.

            appid = sc.Getgamesid();

           
            games = sc.Getgames();
            if (games != null)
            {
                for (int i = 0; i < games.Length; i++)
                {
                    Cmbgames.Items.Add(Convert.ToString(games[i]));
                    
                }

            }
            sc.Close();

        }






        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!(txtdeath.Text.Length == 0 || txtkill.Text.Length == 0))
            {
                ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();

                sc.ClientCredentials.UserName.UserName = "Szarath";
                sc.ClientCredentials.UserName.Password = "Szarath115";
                sc.Open();
                int addinfo = sc.Insertdata(Cmbgames.SelectedIndex + 1, int.Parse(txtkill.Text), int.Parse(txtdeath.Text));
                sc.Close();
            }





        }


        private void btntimer_Click(object sender, EventArgs e)
        {

            Console.WriteLine("start");
         
            currenttime = 0;

            seconds = 0;
            totaltime = int.Parse(txttime.Text.ToString());

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

          
       

            lbltime.Text = "Minutes left:  " + Convert.ToString(((totaltime *60) - seconds)/60) + "        Seconds left: "+ Convert.ToString(((totaltime * 60) - seconds)% 60);

            seconds = seconds + 1;
           
            if (seconds == (totaltime * 60))
            {
                timer1.Stop();
               lbltime.Text = "Played: " + Convert.ToString(totaltime) + " Minutes ";
                
            }
          


        }




        private void btncheck_Click(object sender, EventArgs e)
        {


            if (Cmbgames.SelectedIndex == -1)
            {
            }
            else {

                string url = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?appid="+ appid[Cmbgames.SelectedIndex ]  +"&count=3&maxlength=300&format=json";

                Console.WriteLine(url);
                var webclient = new WebClient();


                var json = webclient.DownloadString(url);



                Steam userinfo = JsonConvert.DeserializeObject<Steam>(json);


             

                txtsnews.Text = "";

                Console.WriteLine(userinfo.appnews.newsitems.Length);
                 for (int i = 0; i < userinfo.appnews.newsitems.Length; i++)
                 {
                     txtsnews.Text += "Title:       " + userinfo.appnews.newsitems[i].title.ToString() + "\r\n\r\n" + "Description:       " + userinfo.appnews.newsitems[i].contents.ToString() + "\r\n\r\n" + "URL:       " + userinfo.appnews.newsitems[i].url.ToString() + "\r\n" + "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\r\n\r\n";



                 }
                 

               
                chart1.Series["Series1"].Points.Clear();

                int k = 0;
                int d = 0;
                ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();

             // sc.ClientCredentials.UserName.UserName = "Szarath";
             //   sc.ClientCredentials.UserName.Password = "Szarath115";






                sc.Open();

                Object[] kills = sc.Getkills(Cmbgames.SelectedIndex + 1);
                Object[] deaths = sc.Getdeaths(Cmbgames.SelectedIndex + 1);
                for (int i = 0; i < kills.Length; i++)
                {
                    k = k + int.Parse(Convert.ToString(kills[i]));

                }

                for (int j = 0; j < deaths.Length; j++)
                {
                    d = d + int.Parse(Convert.ToString(deaths[j]));

                }
                chart1.Series["Series1"].Points.AddXY("Kill", k);

                chart1.Series["Series1"].Points.AddXY("Death", d);




                sc.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}

