using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerTrainingJuli.Pages.Modul4
{
    public class ChatVM
    {
        public List<string> ChatListe { get; set; } = new List<string>();
        public Action onAdd;

        public void Add(string msg)
        {
            ChatListe.Add(msg);
            onAdd?.Invoke();
        }
    }
}
