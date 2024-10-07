﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ComputerGame
    {
        private string name;
        private PegiAgeRating pegiAgeRating;
        private double budgetInMillionsOfDollars;
        private int minimumGpuMemoryInMegabytes;
        private int diskSpaceNeededInGB;
        private int ramNeededInGb;
        private int coresNeeded;
        private double coreSpeedInGhz;

        public ComputerGame(string name,
                            PegiAgeRating pegiAgeRating,
                            double budgetInMillionsOfDollars,
                            int minimumGpuMemoryInMegabytes,
                            int diskSpaceNeededInGB,
                            int ramNeededInGb,
                            int coresNeeded,
                            double coreSpeedInGhz)
        {
            this.name = name;
            this.pegiAgeRating = pegiAgeRating;
            this.budgetInMillionsOfDollars = budgetInMillionsOfDollars;
            this.minimumGpuMemoryInMegabytes = minimumGpuMemoryInMegabytes;
            this.diskSpaceNeededInGB = diskSpaceNeededInGB;
            this.ramNeededInGb = ramNeededInGb;
            this.coresNeeded = coresNeeded;
            this.coreSpeedInGhz = coreSpeedInGhz;
        }

        public string getName()
        {
            return name;
        }

        public PegiAgeRating getPegiAgeRating()
        {
            return pegiAgeRating;
        }

        public double getBudgetInMillionsOfDollars()
        {
            return budgetInMillionsOfDollars;
        }

        public int getMinimumGpuMemoryInMegabytes()
        {
            return minimumGpuMemoryInMegabytes;
        }

        public int getDiskSpaceNeededInGB()
        {
            return diskSpaceNeededInGB;
        }

        public int getRamNeededInGb()
        {
            return ramNeededInGb;
        }

        public int getCoresNeeded()
        {
            return coresNeeded;
        }

        public double getCoreSpeedInGhz()
        {
            return coreSpeedInGhz;
        }
    }

    public enum PegiAgeRating
    {
        P3, P7, P12, P16, P18
    }

    public class Requirements
    {
        private int gpuGb;
        private int HDDGb;
        private int RAMGb;
        private double cpuGhz;
        private int coresNum;

        public Requirements(int gpuGb,
                            int HDDGb,
                            int RAMGb,
                            double cpuGhz,
                            int coresNum)
        {
            this.gpuGb = gpuGb;
            this.HDDGb = HDDGb;
            this.RAMGb = RAMGb;
            this.cpuGhz = cpuGhz;
            this.coresNum = coresNum;
        }

        public int getGpuGb()
        {
            return gpuGb;
        }

        public int getHDDGb()
        {
            return HDDGb;
        }

        public int getRAMGb()
        {
            return RAMGb;
        }

        public double getCpuGhz()
        {
            return cpuGhz;
        }

        public int getCoresNum()
        {
            return coresNum;
        }
    }

    public interface PCGame
    {
        string getTitle();
        int getPegiAllowedAge();
        bool isTripleAGame();
        Requirements getRequirements();
    }

    // Адаптер класса ComputerGame
    public class ComputerGameAdapter : PCGame
    {
        private readonly ComputerGame _computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            _computerGame = computerGame;
        }

        public string getTitle()
        {
            return _computerGame.getName();
        }

        public int getPegiAllowedAge()
        {
            // мин возраст
            return (int)_computerGame.getPegiAgeRating();
        }

        public bool isTripleAGame()
        {
            // если бюджет больше 50 миллионов
            return _computerGame.getBudgetInMillionsOfDollars() > 50;
        }

        public Requirements getRequirements()
        {
            // требования к системе
            return new Requirements(
                _computerGame.getMinimumGpuMemoryInMegabytes() / 1024, // Переводим из МБ в ГБ
                _computerGame.getDiskSpaceNeededInGB(),
                _computerGame.getRamNeededInGb(),
                _computerGame.getCoreSpeedInGhz(),
                _computerGame.getCoresNeeded());
        }
    }
}
