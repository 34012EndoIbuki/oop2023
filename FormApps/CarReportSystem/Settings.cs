﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    //設定保存
    public class Settings {
        public static Settings instance;

        public int MainFormColor { get; set; }
        //コンストラクタ
        private Settings() { }

        static public Settings getInstance() { 
            if(instance == null) {
                instance = new Settings();
            }
            return instance;
        }
    }
}
