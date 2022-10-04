class Board {
    List<string> spaces = new List<string>();

    public Board(){
        for (int i = 1; i<= 9; i++){
            spaces.Add(i.ToString());
        }
    }
    public bool IsPlayerWinner(String Player) {
        
    }
    public bool ContainsUnclaimedSpaces(){
        bool checkDigit = false;

        foreach (string value in spaces)
        {
            if (char.IsDigit(value[0]))
            {
                checkDigit = true;
                break;
            }
        }
        return !checkDigit;
    }
}