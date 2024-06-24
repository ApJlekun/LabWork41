using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Создание анимации для градиентной заливки
            GradientStopCollection gradientStops = ((RadialGradientBrush)MyEllipse.Fill).GradientStops;
            GradientStopAnimationUsingKeyFrames colorAnimation = new GradientStopAnimationUsingKeyFrames();

            // Добавление ключевых кадров
            colorAnimation.KeyFrames.Add(new LinearGradientStopKeyFrame(Colors.Red, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));
            colorAnimation.KeyFrames.Add(new LinearGradientStopKeyFrame(Colors.Green, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            colorAnimation.KeyFrames.Add(new LinearGradientStopKeyFrame(Colors.Blue, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2))));
            colorAnimation.KeyFrames.Add(new LinearGradientStopKeyFrame(Colors.Purple, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(3))));
            colorAnimation.KeyFrames.Add(new LinearGradientStopKeyFrame(Colors.Orange, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(4))));

            // Установка анимации для первого градиентного стопа
            Storyboard.SetTarget(colorAnimation, gradientStops[0]);
            Storyboard.SetTargetProperty(colorAnimation, new PropertyPath(GradientStop.ColorProperty));

            // Создание и запуск Storyboard
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(colorAnimation);
            storyboard.Begin();
        }
    }
}
