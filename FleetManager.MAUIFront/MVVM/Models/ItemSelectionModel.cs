using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.Models;
public class ItemSelectionModel {
    // General purpose class meant for a selection list where the user has to see
    // the name of the particular thing they are selecting but also to keep track
    // of the ID of the item for later database processing 

    public int ID { get; set; }
    public string Name { get; set; }

    public ItemSelectionModel(int id, string name) {
        ID = id;
        Name = name; 
    }
}
