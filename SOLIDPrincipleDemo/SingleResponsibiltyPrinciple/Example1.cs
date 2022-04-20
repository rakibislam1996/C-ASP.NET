using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleDemo
{
    // Violates SRP
    interface IReport
    {
        void AddEntryAt(int index);
        void RemoveEntryAt(int index);
        void SaveToFile(string fileName);
    }
    // Using SRP
    interface IReportEntry
    {
        void AddEntryAt(int index);
        void RemoveEntryAt(int index);
    }
    interface IReportSaver
    {
        void SaveToFile(string fileName);
    }
}
