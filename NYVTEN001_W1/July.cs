using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class July
{
    private List<Horse> horses;

    private July()// default constructor
    {
        horses = new List<Horse>();
    }

    public void AddHorse(Horse horse)
    {
        horses.Add(horse);
    }

    public void DisplayRoster(TextBox textBox)
    {
        textBox.clear();
        foreach (Horse horse in horses)
        {
            textBox.AppendText(horse.HorseDetails() + Environment.NewLine);
        }
    }

    public Horse Favourite()
    {
        return horses.OrderBy(h=>h.AverageTime()).First();
    }
}