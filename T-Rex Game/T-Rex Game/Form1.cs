using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex_Game
{
    /// <summary>
    /// zıplama durumu havada olup olmadığını kontrol etmek için bool türünde, engel hızını fazla hızlı olmaması için 10,
    /// güç değerini hız değeriyle aynı atadım çünkü ikisinin değişimi üzerinden yeni konumları ayarlayabildim, rnd değişkenini başka bir metotta
    /// belirtilen engellerin belirli bir uzaklıkta rasgele oluşması için kullandım, pozisyon değişkenini ise konum belirlemek için kullandım. 
    /// </summary>
    public partial class Form1 : Form
    {
        bool jump = false;
        int jumpSpeed;
        int force = 13;
        int score = 0;
        int obstacleSpeed = 10;
        Random rnd = new Random();
        int position;
        bool isGameOver = false;

        /// <summary>
        /// form ilk çalıştığında GameReset bölümünün aktif hale gelmesini sağladım
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        /// <summary>
        /// Speed metoduyla hız artışını sağladım
        /// Trex in hızını 13 olarak ayarladım aslında bu değer kaç birim yükseğe çıkacağını gösteriyor. force değişkenini
        /// 1'er 1'er azalttım bu da aşağı kontrollü inmesini sağladı.
        /// Trex'in zıplama işleminden sonra eski konumuna geçmesi ve diğer değerlerin zıplama öncesi haline dönmesi için bulunduğu konumun(257) hizasında kalmasını sağladım.
        /// skor değeri highscore değerini geçince ve sıfır olmadığı sürece arka planda kısa süreliğine konfeti oluşup daha sonra da beyaz haline dönüşünü sağladım.
        /// DialogResult sınıfını kullanarak oyun bittiğinde ekrana bir pencere açılıp oynamaya devam edip etmeyeceğinin sorulmasını kullanıcı isterse oyunun tekrar başlamasını
        /// veya kapanmasını, yeni bir rekor kırılmışsa bunun ekranda gösterilmesini,timer kullanarak bu olayların gerçekleşmesini tetikledim. 
        /// gameTimer ile aynı zamanda score değerini belirledim.
        /// Control sınıfından yararlanarak engellerin karakteri geçtikten sonraki konumlarını ayarladım, trex in bulunduğu pictureBox ın çerçevesi ile
        /// Tag ı engel olan başka pictureBox çerçevesi denk gelirse oyunun bitmesini sağladım.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void GameTimerEvent(object sender, EventArgs e)
        {
            Speed();
            score++;
            trex.Top += jumpSpeed;
            txtScore.Text = "Score: " + score;

            if (jump == true && force < 0)
            {
                jump = false;
            }
            if (jump == true)
            {
                jumpSpeed = -13;
                force -= 1;
            }
            else
            {
                jumpSpeed = 13;
            }
            if (trex.Top > 257 && jump == false) 
            {
                force = 13;
                trex.Top = 258;
                jumpSpeed = 0;
            }

            if ((score == Settings1.Default.highScore + 1) && (Settings1.Default.highScore != 0))
            {
                arkaPlan.Image = Properties.Resources.konfeti;
            }
            if (score > Settings1.Default.highScore + 100)
            {
                arkaPlan.Image = Properties.Resources.beyaz_arkaPlan;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "engel")
                {

                    x.Left -= obstacleSpeed; // engellerin sola kayması
                    if (x.Left < -100) 
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 500)+ (x.Width * 2);
                       
                    }

                    if (trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        trex.Image = Properties.Resources.dead;
                        if (score > Settings1.Default.highScore)
                        {
                            MessageBox.Show("Yeni Rekor!" + " " + score.ToString(), " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Settings1.Default.highScore = score;
                            Settings1.Default.Save();

                        }
                        DialogResult dr = MessageBox.Show("Tekrar oynamak ister misin?", "Oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            GameReset();
                        }
                        else
                        {
                            this.Close();
                        }
                        isGameOver = true;
                    }
                }
            }
            // bu geri dönüşsüz metotla engellerin hızını belirli skor değerlerinden sonra artmasını ve
            // bazı aralıklarda karakterin resminin değişmesini sağladım.
            void Speed()
            {
                if (score > 150 && score < 450)
                {
                    obstacleSpeed = 14;

                }
                if (score == 450)
                {
                    obstacleSpeed = 16;
                    trex.Image = Properties.Resources.pink_trex;
                }
                if (score >= 750 && score < 1050)
                {
                    obstacleSpeed = 19;

                }
                if (score == 1050)
                {
                    obstacleSpeed = 22;
                    trex.Image = Properties.Resources.orange_trex;
                }

            }
        }
        /// <summary>
        ///  hangi tuşa basıldığında zıplama olayının tetikleneceğini belirledim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jump == false)
            {
                jump = true;
            }
        }
        /// <summary>
        /// kullanıcı düğmeye basıp bıraktığında zıplama durumunun değişmesi için bir event tasarladım.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (jump == true)
            {
                jump = false;
            }
        }

        /// <summary>
        /// oyun tekrar başladığında karakterlerin eski konumlarına ve resimlerine geri dönüşünü sağladım.
        /// force,jumpSpeed,jump,score,obstacleSpeed değişkenleriyle hız ve skor ayarlamalarını yaptım.
        /// Control sınıfıyla Tag ı engel olan engellerin ekrana çıkmadan önce konumlandırılmasını sağladım ve timerı başlattım.
        /// </summary>
        private void GameReset()
        {
            force = 13;
            jumpSpeed = 0;
            jump = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            label1.Text = "HI: " + Settings1.Default.highScore.ToString();
            trex.Image = Properties.Resources.blue_trex;
            isGameOver = false;
            trex.Top = 258;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "engel")
                {
                    position = this.ClientSize.Width + rnd.Next(0, 100)+ (x.Width * 5);
                    x.Left = position;
                }
            }
            gameTimer.Start();
        }
        /// <summary>
        /// form boyutunun sağa,sola,yukarı veya aşağıya genişletilmesini veya daraltılmasını engelledim.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

    }
}
// settings dosyası kullanarak highscore değerini tutmayı ve gerektiğinde değiştirmeyi sağladım.

      
    

