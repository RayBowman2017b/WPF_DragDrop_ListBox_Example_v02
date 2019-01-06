using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reorder_item_WPF
{

public class MyDropHandler : IDropTarget
    {

        void IDropTarget.DragOver(DropInfo dropInfo)
        {
            if (dropInfo.Data is MSP)
            {
                dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
                dropInfo.Effects = DragDropEffects.Move;
            }
        }

        void IDropTarget.Drop(DropInfo dropInfo)
        {
           
            MSP msp = (MSP)dropInfo.Data;
            ((IList)dropInfo.DragInfo.SourceCollection).Remove(msp);

        }

        //public MyDropHandler(MainWindowViewModel mainWindowViewModel)
        //{
        //    _mainWindowViewModel = mainWindowViewModel;
        //}

        //public void DragOver(IDropInfo dropInfo)
        //{
        //    dropInfo.Effects = DragDropEffects.Copy;
        //}

        //public void Drop(IDropInfo dropInfo)
        //{
        //    _mainWindowViewModel.Name = (string) dropInfo.Data;
        //}
    }    




    class MainViewModel : IDropTarget
    {
        public ObservableCollection<MSP> MSPCollection { get; set; }

        private int V_button_ndx;

        public MainViewModel()
        {
            MSPCollection = new ObservableCollection<MSP>();

            /*  *  /
            MSPCollection.Add(new MSP() { 
                Id = 1,
                Name = "Anis Derbel"
            });

            MSPCollection.Add(new MSP()
            {
                Id = 2,
                Name = "Firas Mdimagh"
            });

            MSPCollection.Add(new MSP()
            {
                Id = 3,
                Name = "Khaled Jemni"
            });

            MSPCollection.Add(new MSP()
            {
                Id = 4,
                Name = "Sahbouch"
            });
            /*  */

            for (V_button_ndx=1; V_button_ndx < 22; V_button_ndx++)
                MSPCollection.Add(new MSP()
                {
                    Id = V_button_ndx,
                    Name = "Button 00" + V_button_ndx
                });
        }

        public void add_new_element ()
        {
            MSP L_new_item = new MSP()
                {
                    Id = V_button_ndx,
                    Name = "Button 00" + V_button_ndx
                };

            V_button_ndx++;

            MSPCollection.Add(L_new_item);
        }

        void IDropTarget.DragOver(DropInfo dropInfo)
        {
            if (dropInfo.Data is MSP)
            {
                dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
                dropInfo.Effects = DragDropEffects.Move;
            }
        }

        void IDropTarget.Drop(DropInfo dropInfo)
        {
           
            MSP msp = (MSP)dropInfo.Data;
            ((IList)dropInfo.DragInfo.SourceCollection).Remove(msp);
        }
    }
}
