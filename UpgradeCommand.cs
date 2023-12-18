namespace KlikkerSpill
{
    internal class UpgradeCommand : ICommand
    {
        private ClickerGame _game;
        public char Character => 'K';

        public UpgradeCommand(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.Upgrade();
        }

    }
}
