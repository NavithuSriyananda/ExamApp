using ExamApp.Api.Controllers;
using ExamApp.Api.Models;
using static ExamApp.Api.Constants.Constants;
using System;
using System.Collections.Generic;

namespace ExamApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageController ctrl = new ImageController();
            ctrl.Add(new Image(123, DateTime.Now, "base64;123$@24ERWSD", EffectTypes.effect1, 132, new int[] { 123, 321 }));
            List<Image> images = ctrl.Get();
            foreach (Image img in images)
            {
                System.Console.WriteLine(img.ToString());
            }
        }
    }
}
