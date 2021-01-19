namespace Impostor.Server.Config
{
    public static class DisconnectMessages
    {
        public const string Error = "알수없는 오류가 발생하였습니다. ";

        public const string Destroyed = "접속하시려는 방은 사라졌습니다. " +
                                        "새 게임을 만들어주세요";

        public const string NotImplemented = "Game listing has not been implemented in Impostor yet for servers " +
                                             "running in server redirection mode.";

        public const string UsernameLength = "닉네임이 너무 깁니다.";

        public const string UsernameIllegalCharacters = "Your username contains illegal characters, please remove them.";
    }
}
