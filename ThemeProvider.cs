using DemoBlazorWASM.Themes;

namespace DemoBlazorWASM
{
    public interface IThemeProvider
    {
        ITheme GetCurrentTheme();

        void ChangesTheme(ITheme theme);
    }

    public class ThemeProvider : IThemeProvider
    {
        private ITheme _currentTheme;

        public ThemeProvider()
        {
            _currentTheme = new DefaultTheme();
        }

        public ITheme GetCurrentTheme()
        {
            return _currentTheme;
        }

        public void ChangesTheme(ITheme theme)
        {
            _currentTheme = theme;
        }
    }
}