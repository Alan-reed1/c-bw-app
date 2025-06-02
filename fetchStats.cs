using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace FirstUI;


public class FetchStats
{
    private int bedsBroken;
    private int bedsLost;
    private int finalKills;
    private int finalDeaths;
    private int kills;
    private int deaths;
    private int wins;
    private int losses;
    private async Task<string> getUUID(string strPlayerName)
    {
        HttpClient Client = new HttpClient();
        HttpResponseMessage response = await Client.GetAsync($"https://api.mojang.com/users/profiles/minecraft/{strPlayerName}");
        string content = await response.Content.ReadAsStringAsync();
        JObject jsonObj = JObject.Parse(content);
        return jsonObj["id"].ToString();
    }

    public string Mode(string strMode)
    {
        switch (strMode)
        {
            case "solos":
                strMode = "eight_one_";
                break;
            case "duos":
                strMode = "eight_two_";
                break;
            case "threes":
                strMode = "three_four_";
                break;
            case "fours":
                strMode = "four_four_";
                break;
            case "4v4":
                strMode = "two_four_";
                break;
            default:
                strMode = "";
                break;

        }
        System.Diagnostics.Debug.WriteLine(strMode);
        return strMode;
    }

    public FetchStats()
    {

    }
    public async Task mkObj(string mode, string playerName)
    {
        await FetchAsync(mode, playerName);
    }

    private async Task FetchAsync(string mode, string playerName)
    {
        string prefix = Mode(mode);
        string uuid = await getUUID(playerName);

        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync($"https://api.hypixel.net/player?key=PRIVATE&uuid={uuid}");

        if (response.IsSuccessStatusCode)
        {
            System.Diagnostics.Debug.WriteLine("Success");
            string content = await response.Content.ReadAsStringAsync();
            JObject jsonObj = JObject.Parse(content);
            JObject bedwarsStats = jsonObj["player"]["stats"]["Bedwars"].ToObject<JObject>();

            bedsBroken = bedwarsStats[prefix + "beds_broken_bedwars"].ToObject<int>();
            bedsLost = bedwarsStats[prefix + "beds_lost_bedwars"].ToObject<int>();
            finalKills = bedwarsStats[prefix + "final_kills_bedwars"].ToObject<int>();
            finalDeaths = bedwarsStats[prefix + "final_deaths_bedwars"].ToObject<int>();
            kills = bedwarsStats[prefix + "kills_bedwars"].ToObject<int>();
            deaths = bedwarsStats[prefix + "deaths_bedwars"].ToObject<int>();
            wins = bedwarsStats[prefix + "wins_bedwars"].ToObject<int>();
            losses = bedwarsStats[prefix + "losses_bedwars"].ToObject<int>();
            System.Diagnostics.Debug.WriteLine(finalKills);
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("nope L");

        }
    }

    public int GetBedsBroken()
    {
        return this.bedsBroken;
    }

    public int GetBedsLost()
    {
        return this.bedsLost;
    }

    public int GetFinalKills()
    {
        return this.finalKills;
        
    }

    public int GetFinalDeaths()
    {
        return this.finalDeaths;
    }

    public int GetKills()
    {
        return this.kills;
    }

    public int GetDeaths()
    {
        return this.deaths;
    }

    public int GetWins()
    {
        return this.wins;
    }

    public int GetLosses()
    {
        return  this.losses;
    }

}

