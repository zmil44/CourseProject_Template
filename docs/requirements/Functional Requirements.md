#Zach Miller

#Functional Requirements
	#Create an account
		##CA1
			Upon clicking create account, User will create a profile with a user-name, password and email
			
		##CA2
			user-name (ref:CA1) must be unique
	
	#Play game
		##PG1
			Upon starting a game, each player will randomly be given a game piece color either red or blue
			
		##PG2
			 User will be able to select a piece (ref:UI1) and it will display available locations to move the piece to (ref:UI2) and will be able to activate the special ability of a piece (ref:UI3)
		
		##PG3
			Upon activation of a pieces special ability (ref:Piece_Special)

		##PG4
			After moving a piece (ref:UI2) control of the board switches to the other user
			
		##PG5
			If a piece is within attack range of an enemy (ref: PG2) user will be able to select that location and that piece will be removed from the game
		
		##PG6
			Game will end if no move can be made or one user quits, or either player loses either the shaman or the priest piece
		
	#User Interface
		##UI1
			User will be able to select a piece with a mouse click
			
		##UI2
			After selecting a piece, user can select where to move piece based upon available locations within range of that piece
		
		##UI3
			User will be able to activate a piece special ability (ref:Piece_Special)
	
#Non-Functional
	
	#View Leader board
		##LB1
			Upon selection of the leader board, user will be shown the top scores by previous players organized by score (ref:SC1) descending
	
	#Score
		SC1
			Each piece will have a score attached to it and final score at end of game will be increased or decreased based on amount of turns
	#Security
		SEC1
			password (ref:CA1) and email (ref:CA1) will be secured using sha512 hashing
	
	#Piece_Special
		##Warrior (Pawns)
			Charge: The piece will move forward two spaces instead of one
		##Mage (Bishops)
			Blink: Piece will be able to jump over pieces in its path
		##Paladin (Knights)
			Concescration: Paladin lays holy ground on all areas around him preventing enemy pieces from moving into those squares for 2 turns
		##Druid (Queen)
			Prowl: Become unable to be attacked for 1 turn
		##Shaman (Horde King)
			Summon Totem of Protection: You may summon one totem that will protect any piece in a surrounding area from being attacked for 1 turn
		##Priest (Alliance King)
			Mind Control: For this turn you may move one of your opponents pieces 
		##Hunter (Rook)
			Arcane Shot: Hunter can shoot over a piece to attack an enemy