using System;
using System.IO;
using System.Collections.Generic;

class Character
{
	public string name;
	public int strength;
	public int dex;
}

class Monster : Character
{
	
}

class Items
{
	string name;	
	
	public Items (string name)
	{
		this.name=name;
	}
}

class Weapons : Items
{
	double damage;
	int strength;
	int dex;
	
	public Weapons (string name,double damage,int strength,int dex): base(name)
	{
		this.damage=damage;
		this.strength=strength;
		this.dex=dex;
	}
}

class itemList
{
	
}


class Room
{
	public string name;
	public string description;
	public int idNum;
	public Random rnd=new Random();
	
	public int cmdMovement(int cmdId, int currentrm)
	{
		Console.Clear();	
		int idNum=rnd.Next(1,5);
		if(currentrm==1)	///Kitchen
		{
			if (cmdId==0 || cmdId==1) return(1);	//north
			if (cmdId==2 || cmdId==3) return(1);	//south
			if (cmdId==4 || cmdId==5) return(5);	//east
			if (cmdId==6 || cmdId==7) return(2);	//west
			if (cmdId==8 || cmdId==9) return(1);//northeast
			if (cmdId==10 || cmdId==11) return(1);	//northwest
			if (cmdId==12 || cmdId==13) return(1);	//southeast
			if (cmdId==14 || cmdId==15) return(1);	//southwest
			if (cmdId==16) return(4);	//up
			if (cmdId==17) return(1);	//down	
		}
		if(currentrm==2)	//Living room
		{
			if (cmdId==0 || cmdId==1) return(2);	//north
			if (cmdId==2 || cmdId==3) return(2);	//south
			if (cmdId==4 || cmdId==5) return(1);	//east
			if (cmdId==6 || cmdId==7) return(2);	//west
			if (cmdId==8 || cmdId==9) return(2);//northeast
			if (cmdId==10 || cmdId==11) return(2);	//northwest
			if (cmdId==12 || cmdId==13) return(2);	//southeast
			if (cmdId==14 || cmdId==15) return(2);	//southwest
			if (cmdId==16) return(2);	//up
			if (cmdId==17) return(6);	//down	
		}
		if(currentrm==4)	//Attic
		{
			if (cmdId==0 || cmdId==1) return(4);	//north
			if (cmdId==2 || cmdId==3) return(4);	//south
			if (cmdId==4 || cmdId==5) return(4);	//east
			if (cmdId==6 || cmdId==7) return(4);	//west
			if (cmdId==8 || cmdId==9) return(4);//northeast
			if (cmdId==10 || cmdId==11) return(4);	//northwest
			if (cmdId==12 || cmdId==13) return(4);	//southeast
			if (cmdId==14 || cmdId==15) return(4);	//southwest
			if (cmdId==16) return(4);	//up
			if (cmdId==17) return(1);	//down	
		}
			if(currentrm==5)	//Behind House
		{
			if (cmdId==0 || cmdId==1) return(6);	//north
			if (cmdId==2 || cmdId==3) return(10);	//south
			if (cmdId==4 || cmdId==5) return(4);	//east
			if (cmdId==6 || cmdId==7) return(1);	//west
			if (cmdId==8 || cmdId==9) return(4);//northeast
			if (cmdId==10 || cmdId==11) return(6);	//northwest
			if (cmdId==12 || cmdId==13) return(5);	//southeast
			if (cmdId==14 || cmdId==15) return(10);	//southwest
			if (cmdId==16) return(5);	//up
			if (cmdId==17) return(5);	//down	
		}
		if(currentrm==6)	//North of House
		{
			if (cmdId==0 || cmdId==1) return(7);	//north
			if (cmdId==2 || cmdId==3) return(6);	//south
			if (cmdId==4 || cmdId==5) return(5);	//east
			if (cmdId==6 || cmdId==7) return(12);	//west
			if (cmdId==8 || cmdId==9) return(6);//northeast
			if (cmdId==10 || cmdId==11) return(6);	//northwest
			if (cmdId==12 || cmdId==13) return(5);	//southeast
			if (cmdId==14 || cmdId==15) return(12);	//southwest
			if (cmdId==16) return(6);	//up
			if (cmdId==17) return(6);	//down	
		}
		if(currentrm==7)	//Forest Path
		{
			if (cmdId==0 || cmdId==1) return(15);	//north
			if (cmdId==2 || cmdId==3) return(6);	//south
			if (cmdId==4 || cmdId==5) return(9);	//east
			if (cmdId==6 || cmdId==7) return(13);	//west
			if (cmdId==8 || cmdId==9) return(7);//northeast
			if (cmdId==10 || cmdId==11) return(7);	//northwest
			if (cmdId==12 || cmdId==13) return(7);	//southeast
			if (cmdId==14 || cmdId==15) return(7);	//southwest
			if (cmdId==16) return(14);	//up
			if (cmdId==17) return(7);	//down	
		}
		if(currentrm==9)	//Dimly-lit forest
		{
			if (cmdId==0 || cmdId==1) return(9);	//north
			if (cmdId==2 || cmdId==3) return(16);	//south
			if (cmdId==4 || cmdId==5) return(9);	//east
			if (cmdId==6 || cmdId==7) return(7);	//west
			if (cmdId==8 || cmdId==9) return(9);//northeast
			if (cmdId==10 || cmdId==11) return(9);	//northwest
			if (cmdId==12 || cmdId==13) return(9);	//southeast
			if (cmdId==14 || cmdId==15) return(9);	//southwest
			if (cmdId==16) return(9);	//up
			if (cmdId==17) return(9);	//down	
		}
		if(currentrm==10)	//South of House
		{
			if (cmdId==0 || cmdId==1) return(10);	//north
			if (cmdId==2 || cmdId==3) return(13);	//south
			if (cmdId==4 || cmdId==5) return(5);	//east
			if (cmdId==6 || cmdId==7) return(12);	//west
			if (cmdId==8 || cmdId==9) return(5);//northeast
			if (cmdId==10 || cmdId==11) return(12);	//northwest
			if (cmdId==12 || cmdId==13) return(10);	//southeast
			if (cmdId==14 || cmdId==15) return(10);	//southwest
			if (cmdId==16) return(10);	//up
			if (cmdId==17) return(10);	//down	
		}
		if(currentrm==14)	//Up a Tree
		{
			if (cmdId==0 || cmdId==1) return(14);	//north
			if (cmdId==2 || cmdId==3) return(14);	//south
			if (cmdId==4 || cmdId==5) return(14);	//east
			if (cmdId==6 || cmdId==7) return(14);	//west
			if (cmdId==8 || cmdId==9) return(14);//northeast
			if (cmdId==10 || cmdId==11) return(14);	//northwest
			if (cmdId==12 || cmdId==13) return(14);	//southeast
			if (cmdId==14 || cmdId==15) return(14);	//southwest
			if (cmdId==16) return(14);	//up
			if (cmdId==17) return(7);	//down	
		}
		
		return(0);
	}
	public void cmdOther(int cmdId)
	{
		if (cmdId==27) Environment.Exit(0);
	}
}



class Zork
{
	static void Main()
	{
		string instruction;
		bool gameEnd=false;
		int cmdId=0;
		int currentrm=1;
		int previousrm=1;
		int repeat=0;
		Character person=new Character();
		Console.Write("Please Enter Your Name:");
		person.name=Console.ReadLine();
		person.strength=10;
		person.dex=10;
		Room[] myroom=new Room[99];
		for(int i = 0;i < myroom.Length;++i)
		myroom[i] = new Room();
		myroom[1].name = "Kitchen";
		myroom[1].description = "A small little kitchen, fully stocked with the most famous food supplies. There is also a ladder which is leaning against the wall, leading to a attic.";
		myroom[1].idNum = 1;
		myroom[2].name = "Living Room";
		myroom[2].description = "The room is furnished with a sofa and coffee table in front of a fireplace. ";
		myroom[2].idNum = 2;
		myroom[3].name = "Bedroom";
		myroom[3].description = "There is a queen-sized bed in the middle of the room. ";
		myroom[3].idNum = 3;
		myroom[4].name = "Attic";
		myroom[4].description = "The attic is cramped and dark. There's an foul smell coming from the right.";
		myroom[4].idNum = 4;
		myroom[5].name = "Behind House";
		myroom[5].description = "The back of the house has a patio and next to it is a beautiful garden.";
		myroom[5].idNum = 5;
		myroom[6].name = "North of House";
		myroom[6].description = "The back of the house has a patio and next to it is a beautiful garden.";
		myroom[6].idNum = 6;
		myroom[7].name = "Forest Path";
		myroom[7].description = "The back of the house has a patio and next to it is a beautiful garden.";
		myroom[7].idNum = 7;
		myroom[9].name = "Dimly lit Forest";
		myroom[9].description = "You entered the forest. The stiff, erect trees enveloped you, blotting out the sunlight and a eerie fog sets in as you walk further.";
		myroom[9].idNum = 9;
		myroom[10].name = "South of House";
		myroom[10].description = "You entered the forest. The stiff, erect trees enveloped you, blotting out the sunlight and a eerie fog sets in as you walk further.";
		myroom[10].idNum = 10;
		myroom[11].name = "Clearing with marked path east/west";
		myroom[11].description = "You entered the forest. The stiff, erect trees enveloped you, blotting out the sunlight and a eerie fog sets in as you walk further.";
		myroom[11].idNum = 11;
		myroom[12].name = "West of House";
		myroom[12].description = " and a eerie fog sets in as you walk further.";
		myroom[12].idNum = 12;
		myroom[13].name = "Dark Forest";
		myroom[13].description = " and a eerie fog sets in as you walk further.";
		myroom[13].idNum = 13;
		myroom[14].name = "Up a Tree";
		myroom[14].description = " You are standing on a branch 15m high";
		myroom[14].idNum = 14;
		myroom[15].name = "Northern Forest Clearing";
		myroom[15].description = "Forest surrounding you.";
		myroom[15].idNum = 15;
		myroom[16].name = "Eastern Forest Clearing";
		myroom[16].description = "Forest surrounding you.";
		myroom[16].idNum = 16;
		StreamReader command = new StreamReader("commands.txt");
		StreamReader weaponList = new StreamReader("weapons.txt");
			String line = command.ReadToEnd();
			String weapons=weaponList.ReadToEnd();
			string[] word=line.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
			string[] word1=weapons.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
			
			//command.Close();
			for (int i=0;i<word.Length;i++)	word[i]=word[i].Trim();
			for (int h=0;h<word1.Length;h++)	word1[h]=word1[h].Trim();
			int count=0;
			//while (count<word1.Length)
			//{
			//	Weapons weapon=new Weapons(word1[count],Convert.ToDouble(word1[count+1]),
			//		Convert.ToInt32(word1[count+2]),Convert.ToInt32(word1[count+3]));
			//	count=count+1;
			//}
			
		while (gameEnd==false)
		{
			for (int j=0;j<1;j++)
			{
				//Console.Clear();
				Console.WriteLine(myroom[currentrm].name);
				Console.WriteLine(myroom[currentrm].description);
				if (repeat==1) Console.WriteLine("You cannot proceed that way");
				//Console.WriteLine(person.name+":"+person.strength+":"+person.dex);
				instruction=Console.ReadLine();
				
				
				for (int i=0;i<word.Length;i++)
				{
					if (instruction.Equals(word[i]))
					{
						cmdId=i;
						repeat=0;
						if (myroom[currentrm].cmdMovement(cmdId,currentrm)==0)
							myroom[currentrm].cmdOther(cmdId);
						else
						{
							previousrm=currentrm;
							currentrm=myroom[currentrm].cmdMovement(cmdId,currentrm);
							if (currentrm==previousrm) repeat++;
						}
					}
				}
			}
		}
	}
}
