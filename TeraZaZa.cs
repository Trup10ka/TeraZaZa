using Terraria.ModLoader;

namespace TeraZaZa;

public class TeraZaZa : Mod
{
      public static TeraZaZa Instance { get; private set; }
      
      public override void Load()
      {
          Instance = this;
      }  
}
