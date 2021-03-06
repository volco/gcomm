﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RiotApi.Net.RestClient.Dto.Game;
using RiotApi.Net.RestClient.Dto.League;
using RiotApi.Net.RestClient.Dto.Summoner;
using RiotApi.Net.RestClient.Dto.Stats;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using RiotApi.Net.RestClient.Dto.LolStaticData.SummonerSpell;
using RiotApi.Net.RestClient.Dto.Stats.Generic;

namespace Data.Models
{
    public class SummonerModel
    {
        public string SummonerKey { get; set; }

        public SummonerDto SummonerDto { get; set; }

        public List<RecentGamesDto.GameDto> RecentGames { get; set; }

        public List<LeagueModel> LeagueModels { get; set; }

        public string ProfileImagePath { get; set; }

        public class LeagueModel
        {
            public string LeagueKey { get; set; }

            public LeagueDto LeagueDto { get; set; }

            public string LeagueName { get; set; }
        }

        public class PlayedChampionModel
        {
            public AggregatedStatsDto RankedStats { get; set; }
            public ChampionDto StaticChampion { get;  set; }

            public string ChampionSpriteImage { get; set; }
        }

        public PlayerStatsSummaryListDto PlayerStats { get; set; }
        
        public List<PlayedChampionModel> PlayedChampions { get; set; }
    }
}