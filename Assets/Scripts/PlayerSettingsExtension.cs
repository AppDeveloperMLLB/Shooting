using Photon.Realtime;
using ExitGames.Client.Photon;

public static class PlayerSettingsExtension {
    private const string ScoreKey = "Score";

    private static readonly Hashtable propsToSet = new Hashtable();

    public static int GetScore(this Player player)
    {
        return (player.CustomProperties[ScoreKey] is int score) ? score : 0;
    }

    public static void AddScore(this Player player, int score)
    {
        propsToSet[ScoreKey] = player.GetScore() + score;
        player.SetCustomProperties(propsToSet);
        propsToSet.Clear();
    }
}

public static class GameRoomProperty
{
    private const string KeyStartTime = "StartTime";

    private static readonly Hashtable propsToSet = new Hashtable();

    public static bool TryGetStartTime(this Room room, out int timestamp)
    {
        if (room.CustomProperties[KeyStartTime] is int value)
        {
            timestamp = value;
            return true;
        } else
        {
            timestamp = 0;
            return false;
        }
    }

    public static void SetStartTime(this Room room, int timestamp)
    {
        propsToSet[KeyStartTime] = timestamp;
        room.SetCustomProperties(propsToSet);
        propsToSet.Clear();
    }
}