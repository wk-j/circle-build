using System;
using FluentScheduler;
using Newtonsoft.Json;

namespace Circle {
    class Program {
        static void Main(string[] args) {
            var a = new {
                A = 100,
                B = 200
            };

            var json = JsonConvert.SerializeObject(a);
            var registry = new Registry();
        }
    }
}
