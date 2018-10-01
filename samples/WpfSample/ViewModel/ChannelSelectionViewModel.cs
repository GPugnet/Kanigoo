using Gpusoft.Kanigoo.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSample.ViewModel
{
    class ChannelSelectionViewModel : INotifyPropertyChanged
    {
        protected Channel selectedChannel;

        public Channel SelectedChannel
        {
            get { return selectedChannel; }
            set
            {
                if (selectedChannel != value)
                {
                    selectedChannel = value;
                    NotifyPropertyChanged("SelectedChannel");
                }
            }
        }


        protected ObservableCollection<Channel> channels;
        public ObservableCollection<Channel> Channels
        {
            get { return channels; }
            set
            {
                if (channels != value)
                {
                    channels = value;
                    NotifyPropertyChanged("Channels");
                }
            }
        }



        public ChannelSelectionViewModel()
        {
            Channels = new ObservableCollection<Channel>();
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
