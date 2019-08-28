using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Examples.Decorator
{
    class Borrowable : LibraryItemDecorator
    {
        private IList<Tuple<string, DateTime>> borrows = new List<Tuple<string, DateTime>>();
        
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public bool Borrow(string userName)
        {
            if (libraryItem.NumberOfCopies == 0)
            {
                return false;
            }

            borrows.Add(new Tuple<string, DateTime>(userName, DateTime.Now));
            libraryItem.NumberOfCopies--;

            return true;
        }

        public void Return(string userName)
        {
            var record = borrows.First(x => x.Item1 == userName);

            borrows.Remove(record);
            libraryItem.NumberOfCopies++;
        }

        public override void PresentInfo()
        {
            base.PresentInfo();

            var details = new StringBuilder("  Borrowers:\n");
            foreach(var borrow in borrows)
            {
                details.Append($"    {borrow.Item1} on {borrow.Item2.ToShortDateString()}\n");
            }

            Console.WriteLine(details.ToString());
        }
    }
}