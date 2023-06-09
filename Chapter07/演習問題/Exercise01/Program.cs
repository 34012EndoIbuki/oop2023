﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);

        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<char, int>();
                for(Char ch = 'A'; ch <= 'Z';ch++) {
                    dict[ch] = text.Count(n => String.Compare(ch.ToString(),n.ToString(),true) == 0);
                }
                foreach (var mon in dict) {
                    Console.WriteLine("{0} = {1}",mon.Key,mon.Value);
                }

                //先生ver
                /*foreach(var c in text) {
                    var uc = char.ToLower(c);
                    if ('a' <= uc && uc <= 'z') {
                        if (dict.ContainsKey(uc)) {
                            dict[uc]++;
                        } else {
                            dict[uc] = 1;
                        }
                    }
                }
                foreach(var item in dict.OrderBy(c => c.Key)) {
                    Console.WriteLine("{ 0} = { 1}", item.Key, item.Value);
                }*/
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<char, int>();
            foreach (var c in text) {
                var uc = char.ToLower(c);
                if ('a' <= uc && uc <= 'z') {
                    if (dict.ContainsKey(uc)) {
                        dict[uc]++;
                    } else {
                        dict[uc] = 1;
                    }
                }
            }
            foreach (var item in dict) {
                Console.WriteLine("{ 0} = { 1}", item.Key, item.Value);

            }
    }
}
