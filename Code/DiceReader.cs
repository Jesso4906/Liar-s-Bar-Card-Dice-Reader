// Placed at the bottom of DiceGamePlayManager.Update()

this.TurnNameText.text = "";
this.TurnNameText.fontSize = 14f;
this.TurnNameText.rectTransform.localPosition = new Vector3(0.02f, -0.3f, 0);
this.TurnNameText.color = Color.red;
this.TurnNameText.text += "Ones: " + CalculateAllDice(1) + ", ";
this.TurnNameText.text += "Twos: " + CalculateAllDice(2) + ", ";
this.TurnNameText.text += "Threes: " + CalculateAllDice(3) + ", ";
this.TurnNameText.text += "Fours: " + CalculateAllDice(4) + ", ";
this.TurnNameText.text += "Fives: " + CalculateAllDice(5) + ", ";
this.TurnNameText.text += "Sixes: " + CalculateAllDice(6);