using ResourcesAndDataBinding.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResourcesAndDataBinding.DataAccess
{
    public class JournalsDataAccess
    {
        public static SQLiteConnection Database;
        private static object collisionLock = new object();

        public JournalsDataAccess()
        {
            Database = new SQLiteConnection(DataAccessHelper.DatabasePath);
            Database.CreateTable<Journal>();
        }

        public List<Journal> GetJournalMembers()
        {
            lock (collisionLock)
            {
                var journals = Database.Table<Journal>();
                var result = journals.Where(c => c.IsJournalMember).ToList();
                return result;
            }
        }

        public void AddJournal(Journal journal)
        {
            lock (collisionLock)
            {
                Database.Insert(journal);
            }
        }

        public void DeleteJournal(Journal journal)
        {
            lock (collisionLock)
            {
                Database.Delete(journal);
            }
        }

        public void EditJournal(Journal journal)
        {
            lock (collisionLock)
            {
                Database.Update(journal);
            }
        }

        public void SaveAll(IEnumerable<Journal> journals)
        {
            lock (collisionLock)
            {
                var existingJournals = journals.Where(c => c.ID != 0);
                var newJournals = journals.Where(c => c.ID == 0);

                Database.UpdateAll(existingJournals);
                Database.InsertAll(newJournals);
            }
        }
    }
}
