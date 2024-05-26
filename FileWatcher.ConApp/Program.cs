//@BaseCode
//MdStart
namespace FileWatcher.ConApp
{
    /// <summary>
    /// Represents the main program class.
    /// </summary>
    public partial class Program
    {
        #region Class-Constructors
        static Program()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        #endregion Class-Constructors

        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            new FileWatcherApp().Run(args);
        }

        #region app methods
        #endregion app methods
    }
 }
 //MdEnd