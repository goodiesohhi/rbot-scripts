using RBot;


public class Script {



	public void ScriptMain(ScriptInterface bot){
		bot.Options.SafeTimings = true;
		bot.Options.RestPackets = true;
		bot.Options.ExitCombatBeforeQuest = true;
		
		bot.Player.LoadBank();
		
		bot.Skills.StartTimer();
        
        while(!bot.ShouldExit()&&bot.Player.GetFactionRank("Loremaster") <10){
		bot.Player.Join("librarium");
		bot.Quests.EnsureAccept(3297);
		//2958
		bot.Player.Join("xantown","r7","Left");
		bot.Player.SetSpawnPoint();
		bot.Inventory.BankAllCoinItems();
		
		bot.Player.HuntForItem("Xan", "Vial of Magic Flame",1,true);
		bot.Player.Join("librarium");
		bot.Quests.EnsureComplete(3297);
	}
}
}