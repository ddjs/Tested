namespace SW
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using System.Windows;

    using Helpers;

    /// <summary>
    /// Interaction logic for MainWindow
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// The time property.
        /// </summary>
        public static readonly DependencyProperty TimeProperty = 
            DependencyProperty.Register("Time", typeof(TimeSpan), typeof(MainWindow), new PropertyMetadata(default(TimeSpan)));

        /// <summary>
        /// The running variable to start and stop our timer. 
        /// </summary>
        private bool running;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The action to take.
        /// </summary>
        public enum ActionToTake
        {
            /// <summary>
            /// The unknown. 
            /// To take as default value.
            /// </summary>
            Unknown,

            /// <summary>
            /// The start.
            /// </summary>
            Start,

            /// <summary>
            /// The stop.
            /// </summary>
            Stop
        }

        /// <summary>
        /// Gets or sets the time currently displayed on the UI
        /// </summary>
        public TimeSpan Time
        {
            get
            {
                return (TimeSpan)GetValue(TimeProperty);
            }

            set
            {
                SetValue(TimeProperty, value);
            }
        }

        /// <summary>
        /// The user has pressed an action button.
        /// </summary>
        /// <param name="sender">
        /// The sender. [ UIElement that was pressed].
        /// </param>
        /// <param name="e">
        /// The event argument.
        /// </param>
        private void ActionButtonPressed(object sender, RoutedEventArgs e)
        {
            // cast our seneder as a UIElement
            var button = sender as UIElement;
            if (button == null)
            {
                // cast failed return.
                return;
            }

            // Convert our UID of the element into an Enum value to 
            // use our switch case on.
            switch (button.Uid.ToEnum<ActionToTake>())
            {
                // user requested a start.
                case ActionToTake.Start:
                    // start our timer.
                    this.RunTimer();
                    break;

                // user request a stop.
                case ActionToTake.Stop:

                    // stop our timer.
                    this.running = false;
                    break;
            }
        }

        /// <summary>
        /// The Timer updating Method
        /// </summary>
        private async void RunTimer()
        {
            // check if we are already running and return if we are.
            if (this.running)
            {
                return;
            }

            // set our running variable true.
            this.running = true;

            // start our timer
            var timer = Stopwatch.StartNew();

            // loop until the user request the timer to stop.
            while (this.running)
            {
                // update our View
                this.Time = timer.Elapsed;

                // wait a few ms to update again.
                await Task.Delay(50);
            }

            // stop the timer. 
            timer.Stop();
        }
    }
}
