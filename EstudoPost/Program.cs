﻿using System;
using EstudoPost.Entities;
namespace EstudoPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that´s awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new zealand",
                "I´m going to visit this wonderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("HELLO MAN");
            Comment c4 = new Comment("No Urdestand!");

            Post p2 = new Post(
                DateTime.Parse("28/06/2018 14:05:44"),
                "Traveling to new zealand",
                "I´m going to visit this wonderful country",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
