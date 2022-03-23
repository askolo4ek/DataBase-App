using System.Collections.ObjectModel;

namespace SchedulingBase
{
    class ArgumentEntry
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public ArgumentEntry(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }

    class ArgumentViewModel
    {
        private static ObservableCollection<ArgumentEntry> arguments;
        public static ObservableCollection<ArgumentEntry> Arguments
        {
            get { return arguments; }
            set { arguments = value; }
        }

        public ArgumentViewModel()
        {
            arguments = new ObservableCollection<ArgumentEntry>();
        }
    }
    class SubroutineEntry
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public ObservableCollection<ArgumentEntry> Arguments { get; set; }

        public SubroutineEntry(string name, string type)
        {
            Name = name;
            Type = type;
            Arguments = new ObservableCollection<ArgumentEntry>();
        }

    }
    class SubroutineViewModel
    {
        private static ObservableCollection<SubroutineEntry> subroutines;
        public static ObservableCollection<SubroutineEntry> Subroutines
        {
            get { return subroutines; }
            set { subroutines = value; }
        }

        private static SubroutineEntry subroutine;
        public static SubroutineEntry Subroutine
        {
            get { return subroutine; }
            set { subroutine = value; }
        }

        public SubroutineViewModel()
        {
            Subroutines = new ObservableCollection<SubroutineEntry>();
        }
    }
}

