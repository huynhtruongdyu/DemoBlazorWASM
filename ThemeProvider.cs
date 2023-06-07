using DemoBlazorWASM.Enums;
using DemoBlazorWASM.Themes;

namespace DemoBlazorWASM
{
    public interface IThemeProvider
    {
        ITheme GetCurrentTheme();

        void ChangesTheme(EnumThemes themes);

        event Action ThemeChangesEvent;
    }

    public class ThemeProvider : IThemeProvider
    {
        public event Action ThemeChangesEvent;

        private ITheme _currentTheme;

        private void NotifyThemeChange() => ThemeChangesEvent?.Invoke();

        public ThemeProvider()
        {
            _currentTheme = new DefaultTheme();
        }

        public ITheme GetCurrentTheme()
        {
            return _currentTheme;
        }

        public void ChangesTheme(EnumThemes themes)
        {
            _currentTheme = themes switch
            {
                EnumThemes.Dark => new DarkTheme(),
                _ => new DefaultTheme()
            };
            NotifyThemeChange();
        }
    }
}