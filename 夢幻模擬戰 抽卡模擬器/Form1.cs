using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 夢幻模擬戰_抽卡模擬器
{
    public partial class Langrisser_lottery : Form
    {
        CardPools pools = new CardPools();
        Langrisser langrisser = new Langrisser();
        static int pool = 0;
        static bool __continue = true;
        public Langrisser_lottery()
        {
            InitializeComponent();
        }

        private void ClearAllItems()
        {
            lottery_results.Items.Clear();
        }
        private void AddItemToResults(string Levels, string HeroName)
        {
            string[] row = { Levels, HeroName };
            var item = new ListViewItem(row);
            lottery_results.Items.Add(item);
        }
        private void UpdateCount()
        {
            lbl_total_count.Text = Langrisser.Total.ToString();
            lbl_SSR_count.Text = Langrisser.SSR_Count.ToString();
            lbl_SR_count.Text = Langrisser.SR_Count.ToString();
            lbl_R_count.Text = Langrisser.R_Count.ToString();
            lbl_SSR_ratio.Text = Math.Round(((Math.Round((decimal)Langrisser.SSR_Count / Langrisser.Total, 4))*100), 2).ToString();
            lbl_SR_ratio.Text = Math.Round(((Math.Round((decimal)Langrisser.SR_Count / Langrisser.Total, 4))*100), 2).ToString();
        }
        private void Langrisser_lottery_Load(object sender, EventArgs e)
        {
            lottery_results.View = View.Details;
            lottery_results.FullRowSelect = true;
            lottery_results.GridLines = true;
            lottery_results.AllowColumnReorder = true;
            lottery_results.MultiSelect = true;
            lottery_results.Columns.Add("稀有度", 100, HorizontalAlignment.Left);
            lottery_results.Columns.Add("英雄名", 200, HorizontalAlignment.Left);

            foreach (string pool in pools.getPools())
            {
                lottery_pools.Items.Add(pool);
            }
            lottery_pools.SelectedIndex = 0;
            pool = lottery_pools.SelectedIndex;
            
            lottery_Simulation();
        }

        private void lottery_Simulation()
        {
            __continue = true;
            Form.CheckForIllegalCrossThreadCalls = false;
            new Thread(() =>
            {
                while (__continue)
                {
                    langrisser.LotteryTenTimes(pool);
                    UpdateCount();
                    Thread.Sleep(1);
                }
            }).Start();
        }

        private void lottery_once_Click(object sender, EventArgs e)
        {
            ClearAllItems();
            CardResults result = langrisser.LotteryOnce(pool);
            AddItemToResults(result.Level, result.HeroName);
            UpdateCount();
            __continue = false;
        }

        private void lottery_ten_Click(object sender, EventArgs e)
        {
            ClearAllItems();
            List<CardResults> results = langrisser.LotteryTenTimes(pool);
            foreach (CardResults result in results)
            {
                AddItemToResults(result.Level, result.HeroName);
            }
            UpdateCount();
        }

        private void lottery_pools_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllItems();
            pool = lottery_pools.SelectedIndex;
        }
    }
    class CardResults
    {
        public string Level { get; set; }
        public string HeroName { get; set; }
        public void Modify(string level, string heroname) 
        {
            this.Level = level;
            this.HeroName = heroname;
        }
    }
    class CardPools
    {
        private List<string> pools = new List<string> { "夏日泳裝姬", "光暗交響曲", "英雄召喚" };
        public List<string>getPools()
        {
            return pools;
        }
    }
    class Langrisser
    {
        List<string> R_Cards = new List<string> { "基斯", "洛加", "斯科特", "路因", "利亞特", "安娜", "皮耶魯", "迪歐斯", "利斯塔", "潔西卡", "蕾蒂西亞" };
        List<string> SR_Cards = new List<string> { "埃格貝爾特", "海恩", "霧風", "伊梅爾達", "艾馬林克", "索尼婭", "芙拉基亞", "娜姆", "芙蕾亞", "莉法妮", "克莉絲", "蘭斯", "巴爾加斯", "法娜", "銀狼", "索菲亞" };
        List<string> SSR_Cards = new List<string> { "巴恩哈特", "利昂", "艾爾文", "雷丁", "雪莉", "莉亞娜", "拉娜", "蒂亞莉絲", "亞魯特謬拉", "迪哈爾特", "露娜", "雪露法妮爾", "安潔莉娜", "波贊魯" };
        public static int SSR_Count = 0, SR_Count = 0, R_Count = 0, Total = 0;

        List<string> Result = new List<string> { };
        public CardResults LotteryOnce(int pool)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            CardResults result = new CardResults();
            int destiny = rnd.Next(0, 100);
            int inx = 0;

            int SSR_Num = 97, SR_Num = 10;
            if (destiny > SSR_Num)
            {
                switch (pool)
                {
                    case 0:
                        inx = rnd.Next(0, 100);
                        if (inx < 30)
                        {
                            result.Modify("SSR", "露娜");
                        }
                        else if (inx < 60)
                        {
                            result.Modify("SSR", "拉娜");
                        }
                        else if (inx < 90)
                        {
                            result.Modify("SSR", "蒂亞莉絲");
                        }
                        else
                        {
                            inx = rnd.Next(0, SSR_Cards.Count());
                            result.Modify("SSR", SSR_Cards[inx]);
                        }
                        break;
                    case 1:
                        inx = rnd.Next(0, 100);
                        if (inx < 45)
                        {
                            result.Modify("SSR", "澤瑞達");
                        }
                        else if (inx < 90)
                        {
                            result.Modify("SSR", "古巨拉");
                        }
                        else
                        {
                            inx = rnd.Next(0, SSR_Cards.Count());
                            result.Modify("SSR", SSR_Cards[inx]);
                        }
                        break;
                    default:
                        inx = rnd.Next(0, SSR_Cards.Count());
                        result.Modify("SSR", SSR_Cards[inx]);
                        break;
                }
                SSR_Count++;
            }
            else if(destiny < SR_Num)
            {
                inx = rnd.Next(0, SR_Cards.Count());
                result.Modify("SR", SR_Cards[inx]);
                SR_Count++;
            }
            else
            {
                inx = rnd.Next(0, R_Cards.Count());
                result.Modify("R", R_Cards[inx]);
                R_Count++;
            }
            Total++;
            return result;
        }
        public List<CardResults> LotteryTenTimes(int pool)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            List<CardResults> result = new List<CardResults>();
            bool SR_Flag = false;

            int SSR_Num = 97, SR_Num = 10;
            for (int i = 0; i < 10; i++)
            {
                int destiny = rnd.Next(0, 100);
                int inx = 0;
                CardResults tmp = new CardResults();
                if(i == 9)
                {
                    if (!SR_Flag)
                    {
                        inx = rnd.Next(0, SR_Cards.Count());
                        tmp.Modify("SR", SR_Cards[inx]);
                        result.Add(tmp);
                        SR_Flag = true;
                        SR_Count++;
                    }
                    else
                    {
                        if (destiny > SSR_Num)
                        {
                            switch(pool)
                            {
                                case 0:
                                    inx = rnd.Next(0, 100);
                                    if (inx < 30)
                                    {
                                        tmp.Modify("SSR", "露娜");
                                    }
                                    else if (inx < 60)
                                    {
                                        tmp.Modify("SSR", "拉娜");
                                    }
                                    else if (inx < 90)
                                    {
                                        tmp.Modify("SSR", "蒂亞莉絲");
                                    }
                                    else
                                    {
                                        inx = rnd.Next(0, SSR_Cards.Count());
                                        tmp.Modify("SSR", SSR_Cards[inx]);
                                    }
                                    result.Add(tmp);
                                    SR_Flag = true;
                                    break;
                                case 1:
                                    inx = rnd.Next(0, 100);
                                    if (inx < 45)
                                    {
                                        tmp.Modify("SSR", "澤瑞達");
                                    }
                                    else if (inx < 90)
                                    {
                                        tmp.Modify("SSR", "古巨拉");
                                    }
                                    else
                                    {
                                        inx = rnd.Next(0, SSR_Cards.Count());
                                        tmp.Modify("SSR", SSR_Cards[inx]);
                                    }
                                    result.Add(tmp);
                                    SR_Flag = true;
                                    break;
                                default:
                                    inx = rnd.Next(0, SSR_Cards.Count());
                                    tmp.Modify("SSR", SSR_Cards[inx]);
                                    result.Add(tmp);
                                    SR_Flag = true;
                                    break;
                            }
                            SSR_Count++;
                        }
                        else if (destiny < SR_Num)
                        {
                            inx = rnd.Next(0, SR_Cards.Count());
                            tmp.Modify("SR", SR_Cards[inx]);
                            result.Add(tmp);
                            SR_Flag = true;
                            SR_Count++;
                        }
                        else
                        {
                            inx = rnd.Next(0, R_Cards.Count());
                            tmp.Modify("R", R_Cards[inx]);
                            result.Add(tmp);
                            R_Count++;
                        }
                    }
                }
                else
                {
                    if (destiny > SSR_Num)
                    {
                        switch (pool)
                        {
                            case 0:
                                inx = rnd.Next(0, 100);
                                if (inx < 30)
                                {
                                    tmp.Modify("SSR", "露娜");
                                }
                                else if (inx < 60)
                                {
                                    tmp.Modify("SSR", "拉娜");
                                }
                                else if (inx < 90)
                                {
                                    tmp.Modify("SSR", "蒂亞莉絲");
                                }
                                else
                                {
                                    inx = rnd.Next(0, SSR_Cards.Count());
                                    tmp.Modify("SSR", SSR_Cards[inx]);
                                }
                                result.Add(tmp);
                                SR_Flag = true;
                                break;
                            case 1:
                                inx = rnd.Next(0, 100);
                                if (inx < 45)
                                {
                                    tmp.Modify("SSR", "澤瑞達");
                                }
                                else if (inx < 90)
                                {
                                    tmp.Modify("SSR", "古巨拉");
                                }
                                else
                                {
                                    inx = rnd.Next(0, SSR_Cards.Count());
                                    tmp.Modify("SSR", SSR_Cards[inx]);
                                }
                                result.Add(tmp);
                                SR_Flag = true;
                                break;
                            default:
                                inx = rnd.Next(0, SSR_Cards.Count());
                                tmp.Modify("SSR", SSR_Cards[inx]);
                                result.Add(tmp);
                                SR_Flag = true;
                                break;
                        }
                        SSR_Count++;
                    }
                    else if (destiny < SR_Num)
                    {
                        inx = rnd.Next(0, SR_Cards.Count());
                        tmp.Modify("SR", SR_Cards[inx]);
                        result.Add(tmp);
                        SR_Flag = true;
                        SR_Count++;
                    }
                    else
                    {
                        inx = rnd.Next(0, R_Cards.Count());
                        tmp.Modify("R", R_Cards[inx]);
                        result.Add(tmp);
                        R_Count++;
                    }
                }
            }
            Total += 10;
            return result;
        }
    }
}
