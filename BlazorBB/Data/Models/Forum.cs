﻿namespace BlazorBB.Data.Models
{
    public class Forum
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string GetURL()
        {
            return $"/forum/{ID}/{Name}";
        }
    }
}
