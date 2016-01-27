grammar SEDefenseLang;
file  : (level LineBreak*)+ EOF;//weird UTF-8 File Prefixes?
level: 'Level ' levelnr ':' LineBreak (wave LineBreak*)+;
wave:  'Wave ' wavenr':' LineBreak enemies LineBreak* pattern LineBreak*;
enemies: 'Enemies: ' (enemy ', '?)+ ' Amount: ' amount;
pattern: 'Pattern: ' (enemyspawn ' Spawn(' spawnPattern ') ')+ 'Delay: ' delay;
levelnr: Int;
wavenr: Int;
enemy: String;
enemyspawn: String;
spawnPattern: Float ',' Float;
delay: Float;
amount: Int;

Int: ('0'..'9')+;
Float: ('0'..'9')* '.' ('0'..'9')+;
LineBreak : '\r'?'\n' | '\r';
String: '"'(('a'..'z')|('A'..'Z')|'_'|('0'..'9'))+'"';