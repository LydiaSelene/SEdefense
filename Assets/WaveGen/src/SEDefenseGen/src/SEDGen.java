import java.awt.geom.Point2D;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;

import javax.swing.JFileChooser;

import org.antlr.v4.runtime.ANTLRInputStream;
import org.antlr.v4.runtime.CommonTokenStream;
import org.antlr.v4.runtime.tree.ParseTreeWalker;


public class SEDGen extends SEDefenseLangBaseListener{
	
	int curLvl;
	Wave curWave;
	ArrayList<Wave> waves= new ArrayList<Wave>();
	
	public static void main(String[] args){
		
		try {
			JFileChooser chooser = new JFileChooser(System.getProperty("user.home"));
			int returnVal = chooser.showOpenDialog(null);
			File infile = null;
		    if(returnVal == JFileChooser.APPROVE_OPTION) {
		    	infile = chooser.getSelectedFile();
		    }else{
		    	System.exit(0);
		    }
		
		    // Get CSV lexer
		    SEDefenseLangLexer lexer = new SEDefenseLangLexer(new ANTLRInputStream(new FileReader(infile)));
		    // Get a list of matched tokens
			CommonTokenStream tokens = new CommonTokenStream(lexer);
			// Pass the tokens to the parser
			SEDefenseLangParser parser = new SEDefenseLangParser(tokens);
			// Specify our entry points
			SEDefenseLangParser.FileContext fileContext = parser.file();
			// Walk it and attach our listener
			ParseTreeWalker walker = new ParseTreeWalker();
			SEDefenseLangBaseListener listener = new SEDGen();
			walker.walk(listener, fileContext);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	@Override
	public void enterLevelnr(SEDefenseLangParser.LevelnrContext ctx){
		curLvl = Integer.parseInt(ctx.getText());
	}
	
	//Fill Stuff
	@Override
	public void enterWave(SEDefenseLangParser.WaveContext ctx){
		//Make new Wave
		curWave = new Wave();
	}
	
	@Override
	public void enterEnemy(SEDefenseLangParser.EnemyContext ctx) {
		curWave.addEnemy(ctx.getText());
	}
	
	@Override
	public void enterAmount(SEDefenseLangParser.AmountContext ctx) {
		curWave.setAmount(Integer.parseInt(ctx.getText()));
	}
	
	@Override
	public void enterEnemyspawn(SEDefenseLangParser.EnemyspawnContext ctx){
		curWave.addPatternEnemy(ctx.getText());
	}
	
	@Override
	public void enterSpawnPattern(SEDefenseLangParser.SpawnPatternContext ctx){
		//get Coordinates
		String pattern = ctx.getText();
		String[] numbers = pattern.split(",");
		Point2D.Float spawnpoint = new Point2D.Float(Float.parseFloat(numbers[0]), Float.parseFloat(numbers[1]));
		curWave.addSpawnCoords(spawnpoint);
	}

	@Override
	public void enterDelay(SEDefenseLangParser.DelayContext ctx) {
		curWave.setDelay(Float.parseFloat(ctx.getText()));
	}
	//Reset Stuff/Make the file
	@Override
	public void exitWave(SEDefenseLangParser.WaveContext ctx){
		//Push Wave before new one is made
		waves.add(curWave);
	}
	
	@Override
	public void exitLevel(SEDefenseLangParser.LevelContext ctx){
		String out = "";
		out = out+"using UnityEngine;\n";
		out = out+"using UnityEditor;\n";
		out = out + "using System.Collections.Generic;\n";
		out = out+"using System.Collections;\n\n";
		//Start Class
		out = out+"public class Level" + curLvl + " : MonoBehaviour{\n";
		ArrayList<String> usedEnemies = new ArrayList<String>();
		//Fill used enemies
		for (Wave wave : waves) {
			for (int i = 0; i < wave.getEnemies().size(); i++) {
				boolean isInList = false;
				for (String enemy : usedEnemies) {
					if (enemy.equals(wave.getEnemies().get(i).substring(1, wave.getEnemies().get(i).length()-1))) {
						isInList = true;
					}
				}
				if (!isInList) {
					usedEnemies.add(wave.getEnemies().get(i).substring(1, wave.getEnemies().get(i).length()-1));
				}
			}
		}
		//create Declarations for enemies
		for (String enemy : usedEnemies) {
			out = out + "\tGameObject " + enemy +";\n";
		}
		//Declare Timings
		for (int i = 0; i < waves.size(); i++) {
			out = out + "\tfloat delay" + i + " = " + waves.get(i).getDelay() + "f;\n";
			out = out + "\tint amount" + i + " = " + waves.get(i).getAmount() + ";\n";
		}
		
		out = out + "\tList<Vector3> waypoints = new List<Vector3>();\n";
		out = out + "\tint wavesamount = " + waves.size() + ";\n";
		out = out + "\tint playingwave = 0;\n";
		out = out + "\tint patternint = 0;\n";
		
		//Begin Start
		out = out+"\tvoid Start(){\n";
		
		//Load Prefabs
		for (String enemy : usedEnemies) {
			out = out + "\t\t" + enemy + " = Resources.Load(\"Prefabs/Enemies/" + enemy + "\", typeof(GameObject)) as GameObject;\n";			
		}
		
		//Load waypoints
		out = out + "\t\tTransform wayPointsChild = transform.GetChild (0);\n";
		out = out + "\t\tfor (int i = 0; i < wayPointsChild.childCount; i++){\n";
		out = out + "\t\t\twaypoints.Add(wayPointsChild.GetChild(i).transform.position);\n";
		out = out + "\t\t}\n";
		
		//End Start
		out = out+"\t}\n";
		//Begin Update
		out = out+"\tvoid Update(){\n";
		
		//Start wave
		out = out+"\tswitch(playingwave){\n";
		for (int i = 0; i < waves.size(); i++) {
			out = out+"\t\tcase " + i + ":\n";
			out = out+"\t\t\twave" + i + "();\n";
			out = out+"\t\t\tbreak;\n";
		}
		//End Wave
		out = out+"\t}\n";
		
		//End Update
		out = out+"\t}\n";
		
		//Methods for waves
		for (int i = 0; i<waves.size();i++) {
			Wave usedWave = waves.get(i);
			//start wavemethod
			out = out + "\t void wave" + i + "(){\n";
			
			//start switch
			out = out + "\t\tswitch(patternint){\n";
			for (int j = 0; j < usedWave.getPatternEnemies().size(); j++) {
				String usedEnemy = usedWave.getPatternEnemies().get(j);
				//open case
				out = out + "\t\t\tcase " + j + ":\n";
				out = out + "\t\t\t\tdelay" + i + " = delay" + i + " - (Time.deltaTime % 60);\n";
				//open if
				out = out + "\t\t\t\tif(delay" + i + " <= 0){\n";
				out = out + "\t\t\t\t\tGameObject m = Instantiate(" + usedEnemy.substring(1, usedEnemy.length()-1) + ", new Vector3(" +usedWave.getPatternCoords().get(j).x + "f," +usedWave.getPatternCoords().get(j).y +"f), Quaternion.identity) as GameObject;\n";
				out = out + "\t\t\t\t\tm.SendMessage (\"setWaypoints\", waypoints, SendMessageOptions.RequireReceiver );\n";
				out = out + "\t\t\t\t\tdelay" + i + " = " + usedWave.getDelay() + "f;\n";
				if (j == usedWave.getPatternEnemies().size()-1) {
					out = out + "\t\t\t\t\tpatternint = 0;\n";
				}else{
					out = out + "\t\t\t\t\tpatternint++;\n";					
				}
				out = out + "\t\t\t\t\tamount" + i + "--;\n";
				//close if
				out = out + "\t\t\t\t}\n";
				out = out + "\t\t\t\tbreak;\n";
			}
			//close switch
			out = out + "\t}\n";
			
			out = out + "\t\tif(amount" + i + " <= 0){\n";
			out = out + "\t\t\tplayingwave++;\n";
			out = out + "\t\t\tpatternint = 0;\n";
			out = out + "\t\t}\n";			
			out = out + "\t}\n";
		}
		//getter for waveamount etc
		out = out + "\tpublic int getWavesAmount(){\n";
		out = out + "\t\treturn wavesamount;\n";
		out = out + "\t}\n";
		
		out = out + "\tpublic int getCurWave(){\n";
		out = out + "\t\treturn playingwave+1;\n";
		out = out + "\t}\n";
		
		//End Class
		out = out+"}\n";
		
		//Write File
		JFileChooser outputchooser = new JFileChooser(System.getProperty("user.home"));
	    outputchooser.setDialogTitle("Choose Save Directory");
	    outputchooser.setFileSelectionMode(JFileChooser.DIRECTORIES_ONLY);
	    File outfile = null;
	    int returnVal = outputchooser.showOpenDialog(null);
	    if(returnVal == JFileChooser.APPROVE_OPTION) {
	    	outfile = new File(outputchooser.getSelectedFile().getAbsolutePath() + "/Level"+curLvl+".cs");
	    }else{
	    	System.exit(0);
	    }
		outfile.delete();
		try {
			outfile.createNewFile();
			FileWriter fout = new FileWriter(outfile);
			fout.write(out);
			fout.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	@Override
	public void exitFile(SEDefenseLangParser.FileContext ctx){
		System.out .println(
				"\nIf no error outputs occurred, then file has valid format!\n");
	}
	
}	
