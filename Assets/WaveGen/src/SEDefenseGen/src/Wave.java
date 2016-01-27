import java.awt.geom.Point2D;
import java.util.ArrayList;


public class Wave {

	ArrayList<String> enemies;
	ArrayList<String> patternEnemies;
	ArrayList<Point2D.Float> patternSpawnCoords;
	float delay;
	int amount;
	
	public Wave(){
		enemies = new ArrayList<String>();
		patternEnemies = new ArrayList<String>();
		patternSpawnCoords = new ArrayList<Point2D.Float>();
	}
	
	public void addEnemy(String enemy){
		enemies.add(enemy);
	}
	public void addPatternEnemy(String enemy){
		patternEnemies.add(enemy);
	}
	public void addSpawnCoords(Point2D.Float coords){
		patternSpawnCoords.add(coords);
	}
	
	public void setDelay(float delay){
		this.delay = delay;
	}
	
	public void setAmount(int amount){
		this.amount = amount;
	}
	
	public int getPatternlength(){
		return patternEnemies.size();
	}
	
	public ArrayList<String> getEnemies(){
		return enemies;
	}
	
	public int getAmount(){
		return amount;
	}
	
	public float getDelay(){
		return delay;
	}
	
	public ArrayList<String> getPatternEnemies(){
		return patternEnemies;
	}
	
	public ArrayList<Point2D.Float> getPatternCoords(){
		return patternSpawnCoords;
	}
}
