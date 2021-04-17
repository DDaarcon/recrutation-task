using System;

namespace ZadanieRekrutacyjne.Classes {
	public partial class Stage {
		public readonly char INTACT_CHAR = ' ';
		public readonly char SHOT_CHAR = 'X';
		

		public enum ShipPresence {Empty, Ship}
		public enum ShotState {Intact, Shot}

		public Stage oppnentsStage;

		private ShipPresence[,] shipBoard;
		public ShotState[,] shotBoard {get; private set;}

		public char[] visibleCharacters {get; private set;}


		private void PlaceShip(int x, int y, bool horizontal, int length) {
			for (int i = 0; i < length; i++) {
				if (horizontal) {
					shipBoard[x + i, y] = ShipPresence.Ship;
				} else {
					shipBoard[x, y + i] = ShipPresence.Ship;
				}
			}
		}
		private void InitializeArrays() {
			shipBoard = new ShipPresence[10,10];
			shotBoard = new ShotState[10, 10];
			visibleCharacters = new char[100];
			for (int i = 0; i < 10; i++) {
				for (int j = 0; j < 10; j++) {
					shipBoard[i, j] = ShipPresence.Empty;
					shotBoard[i, j] = ShotState.Intact;
					visibleCharacters[i * 10 + j] = INTACT_CHAR;
				}
			}
		}

		public Stage() {
			InitializeArrays();
		}

		public void PlaceShips(int[] shipsLengths) {
			var random = new Random();
			for (int i = 0; i < shipsLengths.Length; i++) {
				bool horizontal = random.Next(1) == 1 ? true : false;

				while (true) {
					int xPos, yPos;
					xPos = random.Next(10 - (horizontal ? shipsLengths[i] : 0));
					yPos = random.Next(10 - (!horizontal ? shipsLengths[i] : 0));

					bool collision = false;
					for (int sLen = 0; sLen < shipsLengths[i]; sLen++) {
						if (horizontal) {
							if (shipBoard[xPos + sLen, yPos] == ShipPresence.Ship) {
								collision = true;
								break;
							}
						} else {
							if (shipBoard[xPos, yPos + sLen] == ShipPresence.Ship) {
								collision = true;
								break;
							}
						}
					}

					if (!collision) {
						PlaceShip(xPos, yPos, horizontal, shipsLengths[i]);
						break;
					}
				}
			}
		}

		public ShipPresence ReciveAttack(int x, int y) {
			if (shipBoard[x, y] == ShipPresence.Ship) {
				shotBoard[x, y] = ShotState.Shot;
			}
			return shipBoard[x, y];
		}



}
}