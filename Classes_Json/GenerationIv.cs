using Newtonsoft.Json;

public class GenerationIv
{
    [JsonProperty("diamond-pearl")]
    public DiamondPearl DiamondPearl { get; set; }

    [JsonProperty("heartgold-soulsilver")]
    public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }
    public Platinum platinum { get; set; }
}


