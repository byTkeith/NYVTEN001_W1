﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class July
{
    private List<Horse> horses;

    private July()
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
}