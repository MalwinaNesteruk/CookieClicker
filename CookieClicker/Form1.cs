using CookieClicker.Properties;
using System.Diagnostics.Tracing;
using System.Media;

namespace CookieClicker
{
    public partial class Form1 : Form
    {
        double cookieMultiplier = 1;
        double timeMultiplier = 1;
        double newCookieForCookieMonster = 0;
        double newTime = 0;
        int interval = 0;
        int counter = 0;
        int numberOfSecond = 0;
        double doubleCounter = 0;
        int counterCard = 0;
        int newCardValue = 0;
        int counterOfRoller = 0;
        int counterOfStool = 0;
        int counterOfFlour = 0;
        int counterOfMixer = 0;
        int counterOfOven = 0;
        int newClickPowerValue = 0;
        int counterOfStall = 0;
        int counterOfBakkie = 0;
        int counterOfBakery = 0;
        int counterOfWholesale = 0;
        int counterOfShipping = 0;
        int newSecondPowerValue = 0;
        int cookieForCookieMonster = 0;
        int totalPower = 0;
        int counterMonster = 0;
        bool lockWinWindow = false;
        bool gameOverByMonster = false;
        List<string> listOfCards = new List<string> {"Dostajesz 5 ciastek.", "Dostajesz 50 ciastek.", "Dostajesz 500 ciastek.",
                                                    "Zyskujesz 10% ciastek", "Zyskujesz 20% ciastek", "Zyskujesz 30% ciastek.",
                                                    "Tracisz 5 ciastek.", "Tracisz 50 ciastek.", "Tracisz 500 ciastek.",
                                                    "Tracisz 10% ciastek", "Tracisz 20% ciastek", "Tracisz 30% ciastek.",
                                                    "Dostajesz wa³ek.", "Dostajesz stolnicê.", "Dostajesz m¹kê.", "Dostajesz mikser.", "Dostajesz piekarnik.",
                                                    "Tracisz wa³ek.", "Tracisz stolnicê.", "Tracisz m¹kê.", "Tracisz mikser.", "Tracisz piekarnik.",
                                                    "Dostajesz stragan.", "Dostajesz piekarenkê.", "Dostajesz piekarniê.", "Dostajesz hurtowniê.", "Dostajesz spedycjê.",
                                                    "Tracisz stragan.", "Tracisz piekarenkê.", "Tracisz piekarniê.", "Tracisz hurtowniê.", "Tracisz spedycjê.",
                                                    "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci mniej o 30% mniej ciastek.", "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci mniej o 30% wiêcej ciastek.",
                                                    "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci ciastka 2 razy szybciej.", "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci ciastka 2 razy wolniej."};
        List<int> listOfCValueToGetCard = new List<int> {200, 500, 1000, 2500, 5000, 7500, 10000, 25000, 40000, 50000};
        //List<int> listOfCValueToGetCard = new List<int> { 2, 5, 10, 25, 50, 75, 100, 250, 400, 500};
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCookie_Click(object sender, EventArgs e)
        {
            if (counterOfRoller == 0 && counterOfStool == 0 && counterOfFlour == 0 && counterOfMixer == 0 && counterOfOven == 0)
            {
                counter++;
                label1.Text = counter.ToString();
            }
            else
            {
                counter += 1 + counterOfRoller * int.Parse(cookieRoller.Text) + counterOfStool * int.Parse(cookieStool.Text) + counterOfFlour * int.Parse(cookieFlour.Text)
                    + counterOfMixer * int.Parse(cookieMixer.Text) + counterOfOven * int.Parse(cookieOven.Text);
                label1.Text = counter.ToString();
            }
        }

        private async void label1_TextChanged(object sender, EventArgs e)
        {
            if (counter >= 100000 && lockWinWindow == false) // powinnno byæ 100000
            {
                buttonCookie.Enabled = false;
                CloseEverything();
                lockWinWindow = true;
                label1.Text = counter.ToString();
                label1.Refresh();
                WinWindow winWindow = new WinWindow();
                winWindow.ShowDialog();
            }

            if (counter >= int.Parse(prizeRoller.Text)) 
            {   
                buttonRoller.Enabled = true;
            }
            if (counter >= int.Parse(prizeStool.Text))
            {
                buttonStool.Enabled = true;
            }
            if (counter >= int.Parse(prizeFlour.Text))
            {
                buttonFlour.Enabled = true;
            }
            if (counter >= int.Parse(prizeStall.Text))
            {
                buttonStall.Enabled = true;
            }
            if (counter >= int.Parse(prizeMixer.Text))
            {
                buttonMixer.Enabled = true;
            }
            if (counter >= int.Parse(prizeBakkie.Text))
            {
                buttonBakkie.Enabled = true;
            }
            if (counter >= int.Parse(prizeOven.Text))
            {
                buttonOven.Enabled = true;
            }
            if (counter >= int.Parse(prizeBakery.Text))
            {
                buttonBakery.Enabled = true;
            }
            if (counter >= int.Parse(prizeWholesale.Text))
            {
                buttonWholesale.Enabled = true;
            }
            if (counter >= int.Parse(prizeShipping.Text))
            {
                buttonShipping.Enabled = true;
            }

            if (counter < int.Parse(prizeRoller.Text))
            {
                buttonRoller.Enabled = false;
            }
            if (counter < int.Parse(prizeStool.Text))
            {
                buttonStool.Enabled = false;
            }
            if (counter < int.Parse(prizeFlour.Text))
            {
                buttonFlour.Enabled = false;
            }
            if (counter < int.Parse(prizeStall.Text))
            {
                buttonStall.Enabled = false;
            }
            if (counter < int.Parse(prizeMixer.Text))
            {
                buttonMixer.Enabled = false;
            }
            if (counter < int.Parse(prizeBakkie.Text))
            {
                buttonBakkie.Enabled = false;
            }
            if (counter < int.Parse(prizeOven.Text))
            {
                buttonOven.Enabled = false;
            }
            if (counter < int.Parse(prizeBakery.Text))
            {
                buttonBakery.Enabled = false;
            }
            if (counter < int.Parse(prizeWholesale.Text))
            {
                buttonWholesale.Enabled = false;
            }
            if (counter < int.Parse(prizeShipping.Text))
            {
                buttonShipping.Enabled = false;
            }

            if (counterCard < 10) //tu ma byæ 10
            {
                if (counter >= listOfCValueToGetCard[counterCard])
                {
                    counterCard++;
                    buttonCard.Enabled = true;
                    newCardValue = int.Parse(cardValue.Text) + 1;
                    cardValue.Text = newCardValue.ToString();
                    labelGetCard.Text = "Mo¿esz odebraæ kartê!";
                    await Task.Delay(4000);
                    labelGetCard.Text = string.Empty;
                }
            }
        }

        private void buttonRoller_Click(object sender, EventArgs e)
        {
            counterOfRoller += 1;
            numberRoller.Text = counterOfRoller.ToString();
            counter -= int.Parse(prizeRoller.Text);
            int newPrizeRoller = int.Parse(prizeRoller.Text) + 1;
            prizeRoller.Text = newPrizeRoller.ToString();
            newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieRoller.Text);
            clikPowerValue.Text = newClickPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void buttonStool_Click_1(object sender, EventArgs e)
        {
            counterOfStool += 1;
            numberStool.Text = counterOfStool.ToString();
            counter -= int.Parse(prizeStool.Text);
            int newPrizeStool = int.Parse(prizeStool.Text) + 2;
            prizeStool.Text = newPrizeStool.ToString();
            newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieStool.Text);
            clikPowerValue.Text = newClickPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void buttonFlour_Click_1(object sender, EventArgs e)
        {
            counterOfFlour += 1;
            numberFlour.Text = counterOfFlour.ToString();
            counter -= int.Parse(prizeFlour.Text);
            int newPrizeFlour = int.Parse(prizeFlour.Text) + 5;
            prizeFlour.Text = newPrizeFlour.ToString();
            newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieFlour.Text);
            clikPowerValue.Text = newClickPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void buttonMixer_Click_1(object sender, EventArgs e)
        {
            counterOfMixer += 1;
            numberMixer.Text = counterOfMixer.ToString();
            counter -= int.Parse(prizeMixer.Text);
            int newPrizeMixer = int.Parse(prizeMixer.Text) + 10;
            prizeMixer.Text = newPrizeMixer.ToString();
            newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieMixer.Text);
            clikPowerValue.Text = newClickPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void buttonOven_Click_1(object sender, EventArgs e)
        {
            counterOfOven += 1;
            numberOven.Text = counterOfOven.ToString();
            counter -= int.Parse(prizeOven.Text);
            int newPrizeOven = int.Parse(prizeOven.Text) + 30;
            prizeOven.Text = newPrizeOven.ToString();
            newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieOven.Text);
            clikPowerValue.Text = newClickPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\\Users\\Malwina\\source\\repos\\CookieClicker\\4195.wav";
            player.Load();
            player.Play();
        }

        private void buttonStall_Click(object sender, EventArgs e)
        {
            counterOfStall += 1;
            numberStall.Text = counterOfStall.ToString();
            counter -= int.Parse(prizeStall.Text);
            int newPrizeStall = int.Parse(prizeStall.Text) + 30;
            prizeStall.Text = newPrizeStall.ToString();
            newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieStall.Text);
            secondPowerValue.Text = newSecondPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void buttonBakkie_Click(object sender, EventArgs e)
        {
            counterOfBakkie += 1;
            numberBakkie.Text = counterOfBakkie.ToString();
            counter -= int.Parse(prizeBakkie.Text);
            int newPrizeBakkie = int.Parse(prizeBakkie.Text) + 100;
            prizeBakkie.Text = newPrizeBakkie.ToString();
            newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieBakkie.Text);
            secondPowerValue.Text = newSecondPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void buttonBakery_Click(object sender, EventArgs e)
        {
            counterOfBakery += 1;
            numberBakery.Text = counterOfBakery.ToString();
            counter -= int.Parse(prizeBakery.Text);
            int newPrizeBakery = int.Parse(prizeBakery.Text) + 200;
            prizeBakery.Text = newPrizeBakery.ToString();
            newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieBakery.Text);
            secondPowerValue.Text = newSecondPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void buttonWholesale_Click(object sender, EventArgs e)
        {
            counterOfWholesale += 1;
            numberWholesale.Text = counterOfWholesale.ToString();
            counter -= int.Parse(prizeWholesale.Text);
            int newPrizeWholesale = int.Parse(prizeWholesale.Text) + 400;
            prizeWholesale.Text = newPrizeWholesale.ToString();
            newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieWholesale.Text);
            secondPowerValue.Text = newSecondPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void buttonShipping_Click(object sender, EventArgs e)
        {
            counterOfShipping += 1;
            numberShipping.Text = counterOfShipping.ToString();
            counter -= int.Parse(prizeShipping.Text);
            int newPrizeShipping = int.Parse(prizeShipping.Text) + 1200;
            prizeShipping.Text = newPrizeShipping.ToString();
            newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieShipping.Text);
            secondPowerValue.Text = newSecondPowerValue.ToString();
            label1.Text = counter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += int.Parse(secondPowerValue.Text);
            label1.Text = counter.ToString();
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            totalPower = int.Parse(secondPowerValue.Text) + int.Parse(clikPowerValue.Text);
            if (totalPower > 0 && totalPower <= 50)
            {
                interval = rnd.Next(5000, 20000);
                newTime = Convert.ToDouble(interval) * timeMultiplier;
                timer2.Interval = (int)newTime;
                cookieForCookieMonster = rnd.Next(1, 21);
                newCookieForCookieMonster = Convert.ToDouble(cookieForCookieMonster) * cookieMultiplier;
                cookieForCookieMonster = (int)newCookieForCookieMonster;
            }
            else if (totalPower > 50 && totalPower <= 300)
            {
                interval = rnd.Next(5000, 15000);
                newTime = Convert.ToDouble(interval) * timeMultiplier;
                timer2.Interval = (int)newTime;
                cookieForCookieMonster = rnd.Next(21, 101);
                newCookieForCookieMonster = Convert.ToDouble(cookieForCookieMonster) * cookieMultiplier;
                cookieForCookieMonster = (int)newCookieForCookieMonster;
            }
            else if (totalPower > 300 && totalPower <= 1000)
            {
                interval = rnd.Next(5000, 10000);
                newTime = Convert.ToDouble(interval) * timeMultiplier;
                timer2.Interval = (int)newTime;
                cookieForCookieMonster = rnd.Next(101, 501);
                newCookieForCookieMonster = Convert.ToDouble(cookieForCookieMonster) * cookieMultiplier;
                cookieForCookieMonster = (int)newCookieForCookieMonster;
            }
            else if (totalPower > 1000)
            {
                interval = rnd.Next(4000, 7000);
                newTime = Convert.ToDouble(interval) * timeMultiplier;
                timer2.Interval = (int)newTime;
                cookieForCookieMonster = rnd.Next(501, 2001);
                newCookieForCookieMonster = Convert.ToDouble(cookieForCookieMonster) * cookieMultiplier;
                cookieForCookieMonster = (int)newCookieForCookieMonster;
            }
            ShowLoses(cookieForCookieMonster);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            counterMonster += 1;
            buttonMonster.Enabled = false;
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Malwina\source\repos\CookieClicker\23600.wav";
            player.Load();
            player.Play();
            if (counterMonster == 10)
            {
                gameOverByMonster = true;
                cookieMonsterWarning.Text = "DOIGRA£EŒ SIÊ";
                CloseEverything();
                label1.Text = "0";
                TeasingMonster teasingMonster = new TeasingMonster();
                teasingMonster.ShowDialog();
                await Task.Delay(1000);
                cookieMonsterWarning.Text = string.Empty;
            }
            if (counterMonster == 1)
            {
                cookieMonsterWarning.Text = "EJ, EJ!";
            }
            if (counterMonster == 3)
            {
                cookieMonsterWarning.Text = "NIE DRA¯NIJ MNIE";
            }
            if (counterMonster == 6)
            {
                cookieMonsterWarning.Text = "OSTRZEGAM";
            }
            if (counterMonster == 9)
            {
                cookieMonsterWarning.Text = "UWA¯AJ, JESTEM JU¯ WŒCIEK£Y";
            }
            await Task.Delay(4000);
            buttonMonster.Enabled = true;
            cookieMonsterWarning.Text = string.Empty;
        }

        private async void ShowLoses(int count)
        {
            if (gameOverByMonster == false)
            {
                if (int.Parse(label1.Text) - cookieForCookieMonster > 0)
                {
                    counter -= cookieForCookieMonster;
                    label1.Text = counter.ToString();
                    cookieMonsterText.Text = "Liczba ciastek zjedzonych przez Ciasteczkowego Potwora: " + count.ToString() + ".";
                    await Task.Delay(3000);
                    cookieMonsterText.Text = string.Empty;
                }
                else if (int.Parse(label1.Text) - cookieForCookieMonster <= 0)
                {
                    CloseEverything();
                    label1.Text = "0";
                    LooserWindow looserWindow = new LooserWindow();
                    looserWindow.ShowDialog();
                }
            }
        }

        private void CloseEverything()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            buttonCookie.Enabled = false;
            buttonRoller.Enabled = false;
            buttonStool.Enabled = false;
            buttonFlour.Enabled = false;
            buttonStall.Enabled = false;
            buttonMixer.Enabled = false;
            buttonBakkie.Enabled = false;
            buttonOven.Enabled = false;
            buttonBakery.Enabled = false;
            buttonWholesale.Enabled = false;
            buttonShipping.Enabled = false;
            buttonCard.Enabled = false;
            buttonMonster.Enabled = false;
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer1.Stop();
            timer2.Stop();
            timer1.Start();
            timer2.Start();
            label1.Text = "0";
            label6.Text = string.Empty;
            label7.Text = string.Empty;
            numberOfSecond = 0;
            secondPowerValue.Text = "0";
            clikPowerValue.Text = "1";
            prizeRoller.Text = "5";
            numberRoller.Text = "0";
            prizeStool.Text = "20";
            numberStool.Text = "0";
            prizeFlour.Text = "50";
            numberFlour.Text = "0";
            prizeMixer.Text = "100";
            numberMixer.Text = "0";
            prizeOven.Text = "300";
            numberOven.Text = "0";
            prizeStall.Text = "60";
            numberStall.Text = "0";
            prizeBakkie.Text = "200";
            numberBakkie.Text = "0";
            prizeBakery.Text = "500";
            numberBakery.Text = "0";
            prizeWholesale.Text = "1000";
            numberWholesale.Text = "0";
            prizeShipping.Text = "5000";
            numberShipping.Text = "0";
            cardValue.Text = "0";
            counterMonster = 0;
            counter = 0;
            counterCard = 0;
            counterOfRoller = 0;
            counterOfStool = 0;
            counterOfFlour = 0;
            counterOfMixer = 0;
            counterOfOven = 0;
            newClickPowerValue = 0;
            counterOfStall = 0;
            counterOfBakkie = 0;
            counterOfBakery = 0;
            counterOfWholesale = 0;
            counterOfShipping = 0;
            newSecondPowerValue = 0;
            cookieForCookieMonster = 0;
            gameOverByMonster = false;
            lockWinWindow = false;
            totalPower = 0;
            buttonRoller.Enabled = false;
            buttonStool.Enabled = false;
            buttonFlour.Enabled = false;
            buttonStall.Enabled = false;
            buttonMixer.Enabled = false;
            buttonBakkie.Enabled = false;
            buttonOven.Enabled = false;
            buttonBakery.Enabled = false;
            buttonWholesale.Enabled = false;
            buttonShipping.Enabled = false;
            buttonCookie.Enabled = true;
            buttonMonster.Enabled = true;
            buttonCard.Enabled = false;
            listOfCards = new List<string> {"Dostajesz 5 ciastek.", "Dostajesz 50 ciastek.", "Dostajesz 500 ciastek.",
                                            "Zyskujesz 10% ciastek", "Zyskujesz 20% ciastek", "Zyskujesz 30% ciastek.",
                                            "Tracisz 5 ciastek.", "Tracisz 50 ciastek.", "Tracisz 500 ciastek.",
                                            "Tracisz 10% ciastek", "Tracisz 20% ciastek", "Tracisz 30% ciastek.",
                                            "Dostajesz wa³ek.", "Dostajesz stolnicê.", "Dostajesz m¹kê.", "Dostajesz mikser.", "Dostajesz piekarnik.",
                                            "Tracisz wa³ek.", "Tracisz stolnicê.", "Tracisz m¹kê.", "Tracisz mikser.", "Tracisz piekarnik.",
                                            "Dostajesz stragan.", "Dostajesz piekarenkê.", "Dostajesz piekarniê.", "Dostajesz hurtowniê.", "Dostajesz spedycjê.",
                                            "Tracisz stragan.", "Tracisz piekarenkê.", "Tracisz piekarniê.", "Tracisz hurtowniê.", "Tracisz spedycjê.",
                                            "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci mniej o 30% mniej ciastek.", "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci mniej o 30% wiêcej ciastek.",
                                            "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci ciastka 2 razy szybciej.", "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci ciastka 2 razy wolniej."};
        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonCard_Click(object sender, EventArgs e)
        {
            buttonCard.Enabled = false;
            int numberOfText = rnd.Next(0, listOfCards.Count);
            newCardValue = int.Parse(cardValue.Text) - 1;
            cardValue.Text = newCardValue.ToString();
            buttonCard.BackgroundImage = Image.FromFile(@"C:\Users\Malwina\source\repos\CookieClicker\karta_przod.png");
            buttonCard.Text = listOfCards[numberOfText];
            executeCommandFromTab();
            await Task.Delay(4000);
            listOfCards.RemoveAt(numberOfText);

            buttonCard.BackgroundImage = Image.FromFile(@"C:\Users\Malwina\source\repos\CookieClicker\karta.png");
            buttonCard.Text = string.Empty;
            if (int.Parse(cardValue.Text) >= 1)
            {
                buttonCard.Enabled = true;
            }
            else
            {
                buttonCard.Enabled = false;
            }
        }

        private void executeCommandFromTab()
        {
            if (buttonCard.Text == "Dostajesz 5 ciastek.")
            {
                counter += 5;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Dostajesz 50 ciastek.")
            {
                counter += 50;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Dostajesz 500 ciastek.")
            {
                counter += 500;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Zyskujesz 10% ciastek")////////////////////////
            {
                doubleCounter = Convert.ToDouble(counter) + 0.1 * Convert.ToDouble(counter);
                counter = (int)doubleCounter;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Zyskujesz 20% ciastek")
            {
                doubleCounter = Convert.ToDouble(counter) + 0.2 * Convert.ToDouble(counter);
                counter = (int)doubleCounter;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Zyskujesz 30% ciastek.")
            {
                doubleCounter = Convert.ToDouble(counter) + 0.3 * Convert.ToDouble(counter);
                counter = (int)doubleCounter;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Tracisz 5 ciastek.")
            {
                if (counter > 5)
                {
                    counter -= 5;
                    label1.Text = counter.ToString();
                }
                else
                {
                    counter = 0;
                    label1.Text = counter.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz 50 ciastek.")
            {
                if (counter > 50)
                {
                    counter -= 50;
                    label1.Text = counter.ToString();
                }
                else
                {
                    counter = 0;
                    label1.Text = counter.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz 500 ciastek.")
            {
                if (counter > 500)
                {
                    counter -= 500;
                    label1.Text = counter.ToString();
                }
                else
                {
                    counter = 0;
                    label1.Text = counter.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz 10% ciastek") //////
            {
                doubleCounter = Convert.ToDouble(counter) - 0.1 * Convert.ToDouble(counter);
                counter = (int)doubleCounter;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Tracisz 20% ciastek")
            {

                doubleCounter = Convert.ToDouble(counter) - 0.2 * Convert.ToDouble(counter);
                counter = (int)doubleCounter;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Tracisz 30% ciastek.")
            {

                doubleCounter = Convert.ToDouble(counter) - 0.3 * Convert.ToDouble(counter);
                counter = (int)doubleCounter;
                label1.Text = counter.ToString();
            }

            if (buttonCard.Text == "Dostajesz wa³ek.")
            {
                counterOfRoller += 1;
                numberRoller.Text = counterOfRoller.ToString();
                newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieRoller.Text);
                clikPowerValue.Text = newClickPowerValue.ToString();
            }

            if (buttonCard.Text == "Dostajesz stolnicê.")
            {
                counterOfStool += 1;
                numberStool.Text = counterOfStool.ToString();
                newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieStool.Text);
                clikPowerValue.Text = newClickPowerValue.ToString();
            }

            if (buttonCard.Text == "Dostajesz m¹kê.")
            {
                counterOfFlour += 1;
                numberFlour.Text = counterOfFlour.ToString();
                newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieFlour.Text);
                clikPowerValue.Text = newClickPowerValue.ToString();
            }

            if (buttonCard.Text == "Dostajesz mikser.")
            {
                counterOfMixer += 1;
                numberMixer.Text = counterOfMixer.ToString();
                newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieMixer.Text);
                clikPowerValue.Text = newClickPowerValue.ToString();
            }

            if (buttonCard.Text == "Dostajesz piekarnik.")
            {
                counterOfOven += 1;
                numberOven.Text = counterOfOven.ToString();
                newClickPowerValue = int.Parse(clikPowerValue.Text) + int.Parse(cookieOven.Text);
                clikPowerValue.Text = newClickPowerValue.ToString();
            }

            if (buttonCard.Text == "Tracisz wa³ek.") ////////////////////////////////////////
            {
                if (counterOfRoller > 0)
                {
                    newClickPowerValue = int.Parse(clikPowerValue.Text) - int.Parse(cookieRoller.Text);
                    clikPowerValue.Text = newClickPowerValue.ToString();
                    counterOfRoller -= 1;
                    numberRoller.Text = counterOfRoller.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz stolnicê.")
            {
                if (counterOfStool > 0)
                {
                    newClickPowerValue = int.Parse(clikPowerValue.Text) - int.Parse(cookieStool.Text);
                    clikPowerValue.Text = newClickPowerValue.ToString();
                    counterOfStool -= 1;
                    numberStool.Text = counterOfStool.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz m¹kê.")
            {
                if (counterOfFlour > 0)
                {
                    newClickPowerValue = int.Parse(clikPowerValue.Text) - int.Parse(cookieFlour.Text);
                    clikPowerValue.Text = newClickPowerValue.ToString();
                    counterOfFlour -= 1;
                    numberFlour.Text = counterOfFlour.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz mikser.")
            {
                if (counterOfMixer > 0)
                {
                    newClickPowerValue = int.Parse(clikPowerValue.Text) - int.Parse(cookieMixer.Text);
                    clikPowerValue.Text = newClickPowerValue.ToString();
                    counterOfMixer -= 1;
                    numberMixer.Text = counterOfMixer.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz piekarnik.")
            {
                if (counterOfOven > 0)
                {
                    newClickPowerValue = int.Parse(clikPowerValue.Text) - int.Parse(cookieOven.Text);
                    clikPowerValue.Text = newClickPowerValue.ToString();
                    counterOfOven -= 1;
                    numberOven.Text = counterOfOven.ToString();
                }
            }

            if (buttonCard.Text == "Dostajesz stragan.") //////////////////////////////////////////////
            {
                counterOfStall += 1;
                numberStall.Text = counterOfStall.ToString();
                newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieStall.Text);
                secondPowerValue.Text = newSecondPowerValue.ToString();
            }

            if (buttonCard.Text == "Dostajesz piekarenkê.")
            {
                counterOfBakkie += 1;
                numberBakkie.Text = counterOfBakkie.ToString();
                newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieBakkie.Text);
                secondPowerValue.Text = newSecondPowerValue.ToString();
            }

            if (buttonCard.Text == "Dostajesz piekarniê.")
            {
                counterOfBakery += 1;
                numberBakery.Text = counterOfBakery.ToString();
                newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieBakery.Text);
                secondPowerValue.Text = newSecondPowerValue.ToString();
            }

            if (buttonCard.Text == "Dostajesz hurtowniê.")
            {
                counterOfWholesale += 1;
                numberWholesale.Text = counterOfWholesale.ToString();
                newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieWholesale.Text);
                secondPowerValue.Text = newSecondPowerValue.ToString();
            }

            if (buttonCard.Text == "Dostajesz spedycjê.")
            {
                counterOfShipping += 1;
                numberShipping.Text = counterOfShipping.ToString();
                newSecondPowerValue = int.Parse(secondPowerValue.Text) + int.Parse(cookieShipping.Text);
                secondPowerValue.Text = newSecondPowerValue.ToString();
            }

            if (buttonCard.Text == "Tracisz stragan.") ////////////////////////////////////////
            {
                if (counterOfStall > 0)
                {
                    newSecondPowerValue = int.Parse(secondPowerValue.Text) - int.Parse(cookieStall.Text);
                    secondPowerValue.Text = newSecondPowerValue.ToString();
                    counterOfStall -= 1;
                    numberStall.Text = counterOfStall.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz piekarenkê.")
            {
                if (counterOfBakkie > 0)
                {
                    newSecondPowerValue = int.Parse(secondPowerValue.Text) - int.Parse(cookieBakkie.Text);
                    secondPowerValue.Text = newSecondPowerValue.ToString();
                    counterOfBakkie -= 1;
                    numberBakkie.Text = counterOfBakkie.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz piekarniê.")
            {
                if (counterOfBakery > 0)
                {
                    newSecondPowerValue = int.Parse(secondPowerValue.Text) - int.Parse(cookieBakery.Text);
                    secondPowerValue.Text = newSecondPowerValue.ToString();
                    counterOfBakery -= 1;
                    numberBakery.Text = counterOfBakery.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz hurtowniê.")
            {
                if (counterOfWholesale > 0)
                {
                    newSecondPowerValue = int.Parse(secondPowerValue.Text) - int.Parse(cookieWholesale.Text);
                    secondPowerValue.Text = newSecondPowerValue.ToString();
                    counterOfWholesale -= 1;
                    numberWholesale.Text = counterOfWholesale.ToString();
                }
            }

            if (buttonCard.Text == "Tracisz spedycjê.")
            {
                if (counterOfShipping > 0)
                {
                    newSecondPowerValue = int.Parse(secondPowerValue.Text) - int.Parse(cookieShipping.Text);
                    secondPowerValue.Text = newSecondPowerValue.ToString();
                    counterOfShipping -= 1;
                    numberShipping.Text = counterOfShipping.ToString();
                }
            }

            if (buttonCard.Text == "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci mniej o 30% mniej ciastek.")
            {
                timer3.Start();
            }

            if (buttonCard.Text == "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci mniej o 30% wiêcej ciastek.")
            {
                timer4.Start(); 
            }

            if (buttonCard.Text == "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci ciastka 2 razy szybciej.")
            {
                timer5.Start();
            }

            if (buttonCard.Text == "Ciasteczkowy Potwór przez minutê" + System.Environment.NewLine + "zjada Ci ciastka 2 razy wolniej.")
            {
                timer6.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label6.Text = numberOfSecond.ToString();
            label7.Text = "Czas do koñca trwania akcji z karty:";
            buttonCard.Enabled = false;
            numberOfSecond++;
            cookieMultiplier = 0.7;
            if (numberOfSecond == 62)
            {
                timer3.Stop();
                buttonCard.Enabled = true;
                label6.Text = string.Empty;
                label7.Text = string.Empty;
                cookieMultiplier = 1;
                numberOfSecond = 0;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label6.Text = numberOfSecond.ToString();
            label7.Text = "Czas do koñca trwania akcji z karty:";
            buttonCard.Enabled = false;
            numberOfSecond++;
            cookieMultiplier = 2.0;
            if (numberOfSecond == 62)
            {
                timer4.Stop();
                buttonCard.Enabled = true;
                label6.Text = string.Empty;
                label7.Text = string.Empty;
                cookieMultiplier = 1;
                numberOfSecond = 0;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label6.Text = numberOfSecond.ToString();
            label7.Text = "Czas do koñca trwania akcji z karty:";
            buttonCard.Enabled = false;
            numberOfSecond++;
            timeMultiplier = 0.5;
            if (numberOfSecond == 62)
            {
                timer5.Stop();
                buttonCard.Enabled = true;
                label6.Text = string.Empty;
                label7.Text = string.Empty;
                timeMultiplier = 1;
                numberOfSecond = 0;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            buttonCard.Enabled = false;
            label7.Text = "Czas do koñca trwania akcji z karty:";
            label6.Text = numberOfSecond.ToString();
            numberOfSecond++;
            timeMultiplier = 2.0;
            if (numberOfSecond == 62)
            {
                timer6.Stop();
                buttonCard.Enabled = true;
                label6.Text = string.Empty;
                label7.Text = string.Empty;
                timeMultiplier = 1;
                numberOfSecond = 0;
            }
        }
    }
}