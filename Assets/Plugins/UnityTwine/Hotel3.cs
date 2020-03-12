﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Hotel3.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Hotel3: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
		}

	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@Hotel3()
	{
		this.StartPassage = "Hotel (3)";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
		passage18_Init();
		passage19_Init();
		passage20_Init();
		passage21_Init();
		passage22_Init();
		passage23_Init();
		passage24_Init();
		passage25_Init();
		passage26_Init();
		passage27_Init();
		passage28_Init();
		passage29_Init();
		passage30_Init();
		passage31_Init();
		passage32_Init();
		passage33_Init();
		passage34_Init();
		passage35_Init();
		passage36_Init();
		passage37_Init();
		passage38_Init();
		passage39_Init();
		passage40_Init();
		passage41_Init();
		passage42_Init();
		passage43_Init();
		passage44_Init();
		passage45_Init();
		passage46_Init();
		passage47_Init();
		passage48_Init();
		passage49_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Start

	void passage1_Init()
	{
		this.Passages[@"Start"] = new StoryPassage(@"Start", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("Congratulations on surviving high school and turning 18! Your parents have kicked you out of the house to use your room for storage. Now, it’s time to face the real word and make a living. To get a job, you must first meet all the requirements like education. Let’s see if you can beat the other competitors in the job market and survive. Don’t forget that it will cost you different amounts of coins to meet everyday necessities like food and a place to sleep.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Next", "Choose character", null);
		yield break;
	}


	// .............
	// #2: Choose character

	void passage2_Init()
	{
		this.Passages[@"Choose character"] = new StoryPassage(@"Choose character", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("Choose between Black and White to select which fate awaits you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Black", "Character introduction R", null);
		yield return lineBreak();
		yield return link("White", "Character introduction R", null);
		yield break;
	}


	// .............
	// #3: Character introduction R

	void passage3_Init()
	{
		this.Passages[@"Character introduction R"] = new StoryPassage(@"Character introduction R", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("Your family has never had debt before. Today, they told you that they have decided to invest in you and gave you 700 coins to start you off. Can you survive 2 weeks?");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Use the arrow keys to walk and the mouse to interact.");
		yield break;
	}


	// .............
	// #4: Hotel (1)

	void passage4_Init()
	{
		this.Passages[@"Hotel (1)"] = new StoryPassage(@"Hotel (1)", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("It's getting pretty late, and you need shelter for the night. Now you can choose between staying at a nice and safe hotel for $50, staying at a sketchy motel for $20, and sleeping on the streets with a chance of being mugged and left to die.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("So... do you choose to");
		yield return lineBreak();
		yield return link("Stay at the hotel", "safety", null);
		yield return text(",");
		yield return lineBreak();
		yield return link("Stay at the motel", "motel", null);
		yield return lineBreak();
		yield return text("or");
		yield return lineBreak();
		yield return link("Sleep on the streets", "streets", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #5: Hotel (2)

	void passage5_Init()
	{
		this.Passages[@"Hotel (2)"] = new StoryPassage(@"Hotel (2)", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("You survived one night, but you need a place to stay again tonight. Your options aren't permanent - how could they be, when you have no credit with the bank, much less a bank card?");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Once again, you look through your options for tonight (hotel, motel, streets) but then you realize there's an event in the town tonight, and the police is extra vigilant. The streets aren't safe to sleep in. You could try, but it's very likely that you'd be caught. Everything is much more expensive due to the event. Hotel is $100, motel is $60, and the fine for sleeping out in the streets is a ghastly $250 (that is, if you get caught).");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you stay in the ");
		yield return link("hotel", "safety", null);
		yield return text(", in the ");
		yield return link("motel", "motel2", null);
		yield return text(", or on the ");
		yield return link("streets", "streets2", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #6: Hotel (3)

	void passage6_Init()
	{
		this.Passages[@"Hotel (3)"] = new StoryPassage(@"Hotel (3)", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("You survived two nights, but you need a place to stay again tonight. Your options still aren't permanent, unfortunately.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Yet again, you look through your options for tonight (hotel, motel, streets). The event yesterday finally ended, and the town is pretty empty once more. Prices are down again, with the hotel being $50 and the motel at $20. Police is nowhere to be seen.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you want to stay in the ");
		yield return link("hotel", "safety", null);
		yield return text(", in the ");
		yield return link("motel", "motel3", null);
		yield return text(", or on the ");
		yield return link("streets", "streets3", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #7: Supermarket (1)

	void passage7_Init()
	{
		this.Passages[@"Supermarket (1)"] = new StoryPassage(@"Supermarket (1)", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("You're getting hungry.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("spend $20 for food", "spend $20 for food", null);
		yield return text(" or ");
		yield return link("starve for the night", "starve for the night", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #8: safety

	void passage8_Init()
	{
		this.Passages[@"safety"] = new StoryPassage(@"safety", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("You're safe for the night. But how long will this safety last?");
		yield break;
	}


	// .............
	// #9: motel

	void passage9_Init()
	{
		this.Passages[@"motel"] = new StoryPassage(@"motel", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("Someone knocks on your door in the middle of the night.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("open the door", "motel open door", null);
		yield return text("?");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Or will you ");
		yield return link("pretend not to hear anything", "motel close door", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #10: streets

	void passage10_Init()
	{
		this.Passages[@"streets"] = new StoryPassage(@"streets", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("You find an empty doorway of a shop and plan on spending the night there. But just as you're about to set your meagre belongings down, someone else pushes past you and beats you to the spot.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("start a confrontation", "fight beggar", null);
		yield return text(", or do you ");
		yield return link("find another spot", "find somewhere else", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #11: motel open door

	void passage11_Init()
	{
		this.Passages[@"motel open door"] = new StoryPassage(@"motel open door", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("A heavily built man stands in your doorway. He is holding something in his fist, but you are unable to see what it is exactly. It looks sharp.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("politely ask him to leave", "motel close door", null);
		yield return text(" or ");
		yield return link("shut the door in his face", "angry man", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #12: motel close door

	void passage12_Init()
	{
		this.Passages[@"motel close door"] = new StoryPassage(@"motel close door", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("Footsteps echo along the hallway outside your door. Whoever was outside your door has left for now.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You keep the door tightly ");
		yield return link("shut", "safety", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #13: angry man

	void passage13_Init()
	{
		this.Passages[@"angry man"] = new StoryPassage(@"angry man", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("You shut the door in his face without saying anything. He starts pounding angrily on the door, and all of a sudden the door breaks down.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("He comes for you. You finally see what he's holding in his hand. It's a short dagger.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("He holds you up by your throat. You can feel yourself ");
		yield return link("losing air", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #14: dead

	void passage14_Init()
	{
		this.Passages[@"dead"] = new StoryPassage(@"dead", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("You didn't manage to survive.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Restart", "Start", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #15: fight beggar

	void passage15_Init()
	{
		this.Passages[@"fight beggar"] = new StoryPassage(@"fight beggar", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("You start arguing with the other person about who got there first. The other person shakes their fist at you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("throw a punch", "punch beggar", null);
		yield return text(" or do you ");
		yield return link("retreat", "find somewhere else", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #16: find somewhere else

	void passage16_Init()
	{
		this.Passages[@"find somewhere else"] = new StoryPassage(@"find somewhere else", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		yield return text("You find somewhere else. Thankfully, it is unclaimed, and you quickly claim it as your own and barricade it with scraps you find around you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("It seems like you're ");
		yield return link("safe", "safety", null);
		yield return text(" for now.");
		yield break;
	}


	// .............
	// #17: punch beggar

	void passage17_Init()
	{
		this.Passages[@"punch beggar"] = new StoryPassage(@"punch beggar", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return text("You throw a punch.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You...");
		yield return lineBreak();
		yield return link("Land the hit", "beggar leaves", null);
		yield return lineBreak();
		yield return link("Miss", "beggar wins", null);
		yield break;
	}


	// .............
	// #18: beggar leaves

	void passage18_Init()
	{
		this.Passages[@"beggar leaves"] = new StoryPassage(@"beggar leaves", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		yield return text("You land the punch, and the other person takes one look at you and runs away, leaving their belongings behind.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("There is $20 inside their bag. You seem to be ");
		yield return link("safe", "safety", null);
		yield return text(" for now.");
		yield break;
	}


	// .............
	// #19: beggar wins

	void passage19_Init()
	{
		this.Passages[@"beggar wins"] = new StoryPassage(@"beggar wins", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		yield return text("You miss the punch. The person punches you in the jaw, the eye and the throat. You feel yourself ");
		yield return link("losing conscious", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #20: motel2

	void passage20_Init()
	{
		this.Passages[@"motel2"] = new StoryPassage(@"motel2", new string[]{  }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		yield return text("You move into your motel room for the night. Unfortunately, since the rooms are so overbooked, you have to share your room with a stranger.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("When you get into your room, it's initially empty and you breathe a sigh of relief. However, this doesn't last long.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Halfway through the night, just as you are about to fall asleep, the door opens with a loud bang, and your... roommate saunters in drunkenly.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("At least, you hope it's your roommate.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("continue to sleep", "ignore roommate", null);
		yield return text(" or do you ");
		yield return link("start a confrontation", "angry roommate", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #21: streets2

	void passage21_Init()
	{
		this.Passages[@"streets2"] = new StoryPassage(@"streets2", new string[]{  }, passage21_Main);
	}

	IStoryThread passage21_Main()
	{
		yield return text("You chose to sleep on the streets. Very, very risky move indeed. Out of the corner of your eye, you can see multiple police officers patrolling the streets, occasionally finding people sleeping on the streets and taking those people away. ");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you choose to find a spot inside ");
		yield return link("the park", "sleep in park", null);
		yield return text(" or in ");
		yield return link("an alley", "sleep in alley", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #22: sleep in park

	void passage22_Init()
	{
		this.Passages[@"sleep in park"] = new StoryPassage(@"sleep in park", new string[]{  }, passage22_Main);
	}

	IStoryThread passage22_Main()
	{
		yield return text("You choose a secluded spot in the park to settle down for the night. Just as you lay down on your blankets, a wild dog appears from the darkness and starts growling menacingly at you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("throw the dog whatever food you have", "angry dog", null);
		yield return text(" or ");
		yield return link("shout at the dog", "angry dog", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #23: sleep in alley

	void passage23_Init()
	{
		this.Passages[@"sleep in alley"] = new StoryPassage(@"sleep in alley", new string[]{  }, passage23_Main);
	}

	IStoryThread passage23_Main()
	{
		yield return text("You decide to find a back alley to sleep inside for the night.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Just as you bring your blankets over yourself, a bright light envelops you, and a microphone-enhanced voice tells you the police is taking you into custody, and you have to hand over a $250 fine to bail yourself out.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You're technically ");
		yield return link("safe", "safety", null);
		yield return text(" for the night, but you're also $250 poorer.");
		yield break;
	}


	// .............
	// #24: angry dog

	void passage24_Init()
	{
		this.Passages[@"angry dog"] = new StoryPassage(@"angry dog", new string[]{  }, passage24_Main);
	}

	IStoryThread passage24_Main()
	{
		yield return text("It doesn't work. The dog leaps towards you, and takes a good chunk out of your leg. With no meds, no money, and no-one to ask for help, you ");
		yield return link("bleed out", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #25: ignore roommate

	void passage25_Init()
	{
		this.Passages[@"ignore roommate"] = new StoryPassage(@"ignore roommate", new string[]{  }, passage25_Main);
	}

	IStoryThread passage25_Main()
	{
		yield return text("You ignore the drunken roommate. Thankfully, they don't really do anything apart from singing loudly and falling into their bed, asleep.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You think you're pretty much ");
		yield return link("safe", "safety", null);
		yield return text(" for now.");
		yield break;
	}


	// .............
	// #26: angry roommate

	void passage26_Init()
	{
		this.Passages[@"angry roommate"] = new StoryPassage(@"angry roommate", new string[]{  }, passage26_Main);
	}

	IStoryThread passage26_Main()
	{
		yield return text("You start being angry at your roommate for being loud. Punches are suddenly thrown. Your roommate overpowers you and suffocates you in your bed. Realizing what they've done, they run away in the night. You, on the other hand, aren't so ");
		yield return link("lucky", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #27: motel3

	void passage27_Init()
	{
		this.Passages[@"motel3"] = new StoryPassage(@"motel3", new string[]{  }, passage27_Main);
	}

	IStoryThread passage27_Main()
	{
		yield return text("You decide to stay in the motel for the night.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("When you arrive in your room, you realize quickly that your door does NOT lock. Whilst this normally would not be an issue, you heard gunshots multiple times throughout the day in the general area of the motel.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("do nothing and hope for the best", "unlocked door", null);
		yield return text(" or ");
		yield return link("try to barricade the door with heavy objects", "barricaded door", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #28: streets3

	void passage28_Init()
	{
		this.Passages[@"streets3"] = new StoryPassage(@"streets3", new string[]{  }, passage28_Main);
	}

	IStoryThread passage28_Main()
	{
		yield return text("You decide to stay on the streets for the night.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("While you're deliberating where exactly to settle in, a street gang starts approaching you menacingly.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("run away", "find somewhere else", null);
		yield return text(" or ");
		yield return link("stand your ground", "fight street gang", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #29: fight street gang

	void passage29_Init()
	{
		this.Passages[@"fight street gang"] = new StoryPassage(@"fight street gang", new string[]{  }, passage29_Main);
	}

	IStoryThread passage29_Main()
	{
		yield return text("You decide to stand your ground against the approaching gang members.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("One of them cracks her knuckles and adopts a fighting stance. Another goes to the front and directly tells you to either give them all your money willingly or suffer.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("submit", "bye money", null);
		yield return text(" or ");
		yield return link("attempt to run", "fail and die", null);
		yield break;
	}


	// .............
	// #30: bye money

	void passage30_Init()
	{
		this.Passages[@"bye money"] = new StoryPassage(@"bye money", new string[]{  }, passage30_Main);
	}

	IStoryThread passage30_Main()
	{
		yield return text("You decide to surrender all of your cash to the gang.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("However, they do not leave you alone. They laugh derisively at the cash you just handed them - apparently, that is not enough to satisfy their leader's needs, so they give you a few hard kicks to the ribs for making them suffer their leader's wrath.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You hear a few bones crack. Breathing becomes hard... and you ");
		yield return link("close your eyes", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #31: fail and die

	void passage31_Init()
	{
		this.Passages[@"fail and die"] = new StoryPassage(@"fail and die", new string[]{  }, passage31_Main);
	}

	IStoryThread passage31_Main()
	{
		yield return text("You attempt to run, but they are faster and stronger. They catch you, but not before one gang member makes a cutthroat motion to another. That's the last thing you see before you ");
		yield return link("black out", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #32: unlocked door

	void passage32_Init()
	{
		this.Passages[@"unlocked door"] = new StoryPassage(@"unlocked door", new string[]{  }, passage32_Main);
	}

	IStoryThread passage32_Main()
	{
		yield return text("The door remains unlocked, and you go to sleep.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Halfway through the night, around 3 AM, a masked person comes in and fires five shots. Two of them pierce through your body. They then leave, and you are left to ");
		yield return link("bleed out", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #33: barricaded door

	void passage33_Init()
	{
		this.Passages[@"barricaded door"] = new StoryPassage(@"barricaded door", new string[]{  }, passage33_Main);
	}

	IStoryThread passage33_Main()
	{
		yield return text("You barricade the door to the best of your ability, and then you go to sleep.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Footsteps echo in the hallway all night, and you hear a couple of more gunshots, but no one manages to enter your room, ");
		yield return link("thankfully", "safety", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #34: Hotel (4)

	void passage34_Init()
	{
		this.Passages[@"Hotel (4)"] = new StoryPassage(@"Hotel (4)", new string[]{  }, passage34_Main);
	}

	IStoryThread passage34_Main()
	{
		yield return text("You somehow managed to survive for three nights. You need a place to stay again tonight.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You look through your options for tonight (hotel, motel, streets). The town is eerily quiet tonight. Prices are at their lowest, with the hotel being $30 and the motel at $10. Police is, again, nowhere to be seen.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you want to stay in the ");
		yield return link("hotel", "safety", null);
		yield return text(", in the ");
		yield return link("motel", "motel4", null);
		yield return text(", or on the ");
		yield return link("streets", "streets4", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #35: motel4

	void passage35_Init()
	{
		this.Passages[@"motel4"] = new StoryPassage(@"motel4", new string[]{  }, passage35_Main);
	}

	IStoryThread passage35_Main()
	{
		yield return text("You decide to stay at the motel.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("It IS pretty quiet tonight, and that's odd. The motel is usually bustling with activity, whether it be illicit or legal.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("It's almost... too quiet.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you ");
		yield return link("double lock the doors", "safety", null);
		yield return text(" or ");
		yield return link("stay up late to keep watch", "stay up late", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #36: streets4

	void passage36_Init()
	{
		this.Passages[@"streets4"] = new StoryPassage(@"streets4", new string[]{  }, passage36_Main);
	}

	IStoryThread passage36_Main()
	{
		yield return text("You decide to live on the streets. It's actually pretty ");
		yield return link("safe", "safety", null);
		yield return text(" tonight. Seems like you got lucky.");
		yield break;
	}


	// .............
	// #37: stay up late

	void passage37_Init()
	{
		this.Passages[@"stay up late"] = new StoryPassage(@"stay up late", new string[]{  }, passage37_Main);
	}

	IStoryThread passage37_Main()
	{
		yield return text("You decide to stay up late to keep watch.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("The silence is unnerving.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("All of a sudden, you hear a steady tap, tap that comes from the hallway.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You grab the nearest object to you, which is a...");
		yield return lineBreak();
		yield return link("lamp", "motel4 survive", null);
		yield return lineBreak();
		yield return link("pen", "motel4 dead", null);
		yield break;
	}


	// .............
	// #38: motel4 survive

	void passage38_Init()
	{
		this.Passages[@"motel4 survive"] = new StoryPassage(@"motel4 survive", new string[]{  }, passage38_Main);
	}

	IStoryThread passage38_Main()
	{
		yield return text("You pick up the lamp.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Someone barges into your room, and you immediately swing the lamp at them. They fall unconscious to the ground, and you run without thinking.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Survival is your priority.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You live to see another ");
		yield return link("day", "safety", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #39: motel4 dead

	void passage39_Init()
	{
		this.Passages[@"motel4 dead"] = new StoryPassage(@"motel4 dead", new string[]{  }, passage39_Main);
	}

	IStoryThread passage39_Main()
	{
		yield return text("You pick up the pen.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Someone barges into your room, giving you no time to react. Your pen falls to the ground.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Sketchy motels are sketchy for a reason.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("The lights go ");
		yield return link("out", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #40: Hotel (5)

	void passage40_Init()
	{
		this.Passages[@"Hotel (5)"] = new StoryPassage(@"Hotel (5)", new string[]{  }, passage40_Main);
	}

	IStoryThread passage40_Main()
	{
		yield return text("You survived four nights.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("One more night, and you'll be able to stay with your friend, who will be coming back in town tomorrow.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Time to look through your options for tonight.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("For some reason, the town has become attractive to tourists overnight, and the accommodations in the town are once again experiencing price surges. One hotel room is $70 (ridiculous), and one motel room is $50 (even more ridiculous).");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Staying on the streets is risky, but you don't think the police will be patrolling again.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you want to stay in the ");
		yield return link("hotel", "safety", null);
		yield return text(", in the ");
		yield return link("motel", "motel5", null);
		yield return text(", or on the ");
		yield return link("streets", "streets5", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #41: motel5

	void passage41_Init()
	{
		this.Passages[@"motel5"] = new StoryPassage(@"motel5", new string[]{  }, passage41_Main);
	}

	IStoryThread passage41_Main()
	{
		yield return text("You choose to stay at the motel for your last night.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Somehow, the motel gets sketchier every single time you get there. How spooky.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you choose ");
		yield return link("the room on 4/F", "the room on 4/F", null);
		yield return text(" or ");
		yield return link("the room on 13/F", "the room on 13/F", null);
		yield break;
	}


	// .............
	// #42: streets5

	void passage42_Init()
	{
		this.Passages[@"streets5"] = new StoryPassage(@"streets5", new string[]{  }, passage42_Main);
	}

	IStoryThread passage42_Main()
	{
		yield return text("You decide to sleep on the streets for your final day alone.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Once again, you have the choice between ");
		yield return link("the park", "sleep in park", null);
		yield return text(" and ");
		yield return link("the alley", "sleep in alley", null);
		yield return text(". What do you choose?");
		yield break;
	}


	// .............
	// #43: the room on 4/F

	void passage43_Init()
	{
		this.Passages[@"the room on 4/F"] = new StoryPassage(@"the room on 4/F", new string[]{  }, passage43_Main);
	}

	IStoryThread passage43_Main()
	{
		yield return text("You chose the room on 4/F.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("The room smells musky, like sweat and unwashed clothing.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you spend the night ");
		yield return link("thinking about the future", "thinking about the future", null);
		yield return text(" or do you ");
		yield return link("go straight to bed", "go straight to bed", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #44: the room on 13/F

	void passage44_Init()
	{
		this.Passages[@"the room on 13/F"] = new StoryPassage(@"the room on 13/F", new string[]{  }, passage44_Main);
	}

	IStoryThread passage44_Main()
	{
		yield return text("You chose the room on 13/F.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("The room smells overly sweet, like your aunt's perfume when she's drunk.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Do you spend the night ");
		yield return link("thinking about the future", "thinking about the future", null);
		yield return text(" or do you ");
		yield return link("go straight to bed", "go straight to bed", null);
		yield return text("?");
		yield break;
	}


	// .............
	// #45: thinking about the future

	void passage45_Init()
	{
		this.Passages[@"thinking about the future"] = new StoryPassage(@"thinking about the future", new string[]{  }, passage45_Main);
	}

	IStoryThread passage45_Main()
	{
		yield return text("You spend quite some time thinking about your future.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Being kicked out of the house felt really bad, but you have high hopes for the future, especially now that you've survived 4.5 days.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("This hope carries you ");
		yield return link("through the night", "win game", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #46: go straight to bed

	void passage46_Init()
	{
		this.Passages[@"go straight to bed"] = new StoryPassage(@"go straight to bed", new string[]{  }, passage46_Main);
	}

	IStoryThread passage46_Main()
	{
		yield return text("You go straight to bed, thinking about nothing in particular, but expecting to wake up to a brighter future.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("... Except, you don't wake up.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Motels are sketchy, ");
		yield return link("after all", "dead", null);
		yield return text(".");
		yield break;
	}


	// .............
	// #47: win game

	void passage47_Init()
	{
		this.Passages[@"win game"] = new StoryPassage(@"win game", new string[]{  }, passage47_Main);
	}

	IStoryThread passage47_Main()
	{
		yield return text("Congratulations, you have managed to survive all five days!");
		yield break;
	}


	// .............
	// #48: spend $20 for food

	void passage48_Init()
	{
		this.Passages[@"spend $20 for food"] = new StoryPassage(@"spend $20 for food", new string[]{  }, passage48_Main);
	}

	IStoryThread passage48_Main()
	{
		yield return text("Your belly fills up. It feels really, really nice to have food in your stomach again.");
		yield break;
	}


	// .............
	// #49: starve for the night

	void passage49_Init()
	{
		this.Passages[@"starve for the night"] = new StoryPassage(@"starve for the night", new string[]{  }, passage49_Main);
	}

	IStoryThread passage49_Main()
	{
		yield return text("You starve for the night. You're getting weaker... and weaker.");
		yield break;
	}


}