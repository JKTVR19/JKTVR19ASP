﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FootBall_JKTVR19.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Display(Name = "Фамилия имя игрока")]
        public string Name { get; set; }
        [Display(Name = "Возраст игрока (лет)")]
        public int Age { get; set; }
        [Display(Name = "Позиция на поле")]
        public string Position { get; set; }
        [Display(Name = "Фото")]
        public byte[] Photo { get; set; }
        public string PhotoType { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}